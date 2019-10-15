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
        public IActionResult Photo()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Photo(Portfolio mediaFile)
        {

            if (mediaFile != null)
            {
                var file = HttpContext.Request.Form.Files;
                if (file.Count != 0)
                {
                    string imgPath = "wwwroot/images/";
                    string imgName = Guid.NewGuid().ToString();
                    string extension = "";
                    for (int i = file[0].FileName.Length - 1; i > 0; i--)
                    {
                        extension = file[0].FileName[i].ToString() + extension;
                        if (file[0].FileName[i] == '.') break;
                    }

                    string fullpath = imgPath + imgName + extension;
                    if (extension == ".jpg" || extension == ".gif" || extension == ".webm" || extension == ".jpeg" || extension == ".png")
                    {
                        using (var fileStream = new FileStream(fullpath, FileMode.Create))
                        {
                            file[0].CopyTo(fileStream);
                        }
                        mediaFile.ImageURL = imgName + extension;
                    }
                }
            mediaDbContext.Portfolios.Add(mediaFile);
            mediaDbContext.SaveChanges();
            }
            return RedirectToAction("photo", "portfolio");
        }
        [HttpGet]
        public IActionResult Media()
        {
            return View();
        }
    }
}