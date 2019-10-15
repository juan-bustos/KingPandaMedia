using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using KingPandaMedia.Models.Tables;

namespace KingPandaMedia.Models.ViewModels
{
    public class PhotoViewModel
    {
        public int ImageID { get; set; }

        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }

        public string MediaCategory { get; set; }

        public string ImageURL { get; set; }
        public IEnumerable<Portfolio> Media { get; set; }
    }
}
