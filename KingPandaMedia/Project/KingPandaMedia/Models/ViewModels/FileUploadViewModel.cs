using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingPandaMedia.Models.ViewModels
{
    public class FileUploadViewModel
    {
        public IFormFile FilePath { get; set; }
    }
}
