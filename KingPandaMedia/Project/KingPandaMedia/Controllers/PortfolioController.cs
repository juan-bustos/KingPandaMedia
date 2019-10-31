using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KingPandaMedia.Models.EFRepository;
using KingPandaMedia.Models;
using KingPandaMedia.Models.Tables;
using KingPandaMedia.Models.ViewModels;
using KingPandaMedia.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace KingPandaMedia.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioRepository portfolioRepository;
        private readonly KingPandaMediaDbContext mediaDbContext;

        public PortfolioController(IPortfolioRepository repository, KingPandaMediaDbContext dbContext)
        {
            this.mediaDbContext = dbContext;
            this.portfolioRepository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Photo()
        {
            return View(
                new PhotoViewModel
                {
                    Photo = portfolioRepository.Portfolios
                });
        }
        [Authorize(Roles = "Team Member")]
        [HttpPost]
        public async Task<IActionResult> Photo(PhotoViewModel mediaFile)
        {

            if (mediaFile != null)
            {
                var file = HttpContext.Request.Form.Files;
                bool uploadSuccess = false;
                string uploadedUri = null;
                if (file.Count != 0)
                {                    
                    string imgName = Guid.NewGuid().ToString();
                    string extension = Path.GetExtension(file[0].FileName);                
                    if (extension == ".jpg" || extension == ".gif" || extension == ".webm" || extension == ".jpeg" || extension == ".png")
                    {
                        extension = extension.Substring(1);
                        mediaFile.ImageURL = imgName + '.' + extension;
                        using var stream = file[0].OpenReadStream();
                        (uploadSuccess, uploadedUri) = await UploadToBlob(mediaFile.ImageURL, stream, extension);
                        TempData["uploadedUri"] = uploadedUri;
                    }
                    else
                    {
                        mediaFile.ImageURL = null;
                    }
                }
            mediaDbContext.Portfolios.Add(mediaFile);
            mediaDbContext.SaveChanges();
            }
            return RedirectToAction("photo", "portfolio");
        }
        private async Task<(bool, string)> UploadToBlob(string filename, Stream stream = null, string extension = "")
        {
            string ConnectionString = "DefaultEndpointsProtocol=https;AccountName=kingpandamediastorage;AccountKey=B61W9AiqiLOEMEkqS6LYrf1GqS/OVR3e52jhuaGcjOElxcYnJZji8064cf7O6zuaXsR+9ZdbwEWxkKYgDDldRw==;EndpointSuffix=core.windows.net";
            if (CloudStorageAccount.TryParse(ConnectionString, out CloudStorageAccount storageAccount))
            {
                try
                {
                    CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();

                    CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference("kpmedia");
                    BlobContainerPermissions permissions = new BlobContainerPermissions
                    {
                        PublicAccess = BlobContainerPublicAccessType.Blob
                    };
                    await cloudBlobContainer.SetPermissionsAsync(permissions);

                    CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(filename);

                    if (stream != null)
                    {
                        if (extension.Equals("webm"))
                        {
                            cloudBlockBlob.Properties.ContentType = "video/" + extension;
                        }
                        else
                        {
                            cloudBlockBlob.Properties.ContentType = "images/" + extension;
                        }
                        await cloudBlockBlob.UploadFromStreamAsync(stream);
                    }
                    else
                    {
                        return (false, null);
                    }
                    return (true, cloudBlockBlob.SnapshotQualifiedStorageUri.PrimaryUri.ToString());
                }
                catch (StorageException)
                {
                    return (false, null);
                }
            }
            else
            {
                return (false, null);
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Video()
        {
            return View(
                new VideoViewModel
                {
                    Video = portfolioRepository.Portfolios
                });
        }
        [Authorize(Roles = "Team Member")]
        [HttpPost]
        public async Task<IActionResult> Video(VideoViewModel mediaFile)
        {

            if (mediaFile != null)
            {
                var file = HttpContext.Request.Form.Files;
                bool uploadSuccess = false;
                string uploadedUri = null;
                if (file.Count != 0)
                {
                    string imgName = Guid.NewGuid().ToString();
                    string extension = Path.GetExtension(file[0].FileName).ToLower();
                    if (extension == ".jpg" || extension == ".gif" || extension == ".webm" || extension == ".jpeg" || extension == ".png")
                    {
                        extension = extension.Substring(1);
                        mediaFile.ImageURL = imgName + '.' + extension;
                        using var stream = file[0].OpenReadStream();
                        (uploadSuccess, uploadedUri) = await UploadToBlob(mediaFile.ImageURL, stream, extension);
                        TempData["uploadedUri"] = uploadedUri;
                    }
                    else
                    {
                        mediaFile.ImageURL = null;
                    }
                }
                mediaDbContext.Portfolios.Add(mediaFile);
                mediaDbContext.SaveChanges();
            }
            return RedirectToAction("video", "portfolio");
        }
        [HttpGet]
        public IActionResult Media()
        {
            return View();
        }
    }
}