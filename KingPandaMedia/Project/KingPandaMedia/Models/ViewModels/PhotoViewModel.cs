using System;
using System.Collections.Generic;
using KingPandaMedia.Controllers;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia.Models.ViewModels
{
    public class PhotoViewModel : Portfolio
    {
        public IEnumerable<Portfolio> Photo { get; set; }
    }
}
