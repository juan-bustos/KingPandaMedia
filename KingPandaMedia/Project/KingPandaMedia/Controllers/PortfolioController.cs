using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KingPandaMedia.Models.EFRepository;
using KingPandaMedia.Models;
using KingPandaMedia.Models.ViewModels;
using KingPandaMedia.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace KingPandaMedia.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly KingPandaMediaDbContext mediaDbContext;
        private readonly IPortfolioRepository portfolioRepository;
        private readonly IWebHostEnvironment hostingEnvironment;

        public PortfolioController(IPortfolioRepository portfolio, KingPandaMediaDbContext dbContext, IWebHostEnvironment hostingEnvironment)
        {
            portfolioRepository = portfolio;
            mediaDbContext = dbContext;
            this.hostingEnvironment = hostingEnvironment;
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
    }
}