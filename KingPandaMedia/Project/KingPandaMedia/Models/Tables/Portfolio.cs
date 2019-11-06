using KingPandaMedia.Controllers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingPandaMedia.Models.Tables
{
    public class Portfolio
    {
        [Key]
        public int ImageID { get; set; }

        [ForeignKey("EmployeeID")]
        public virtual KPMUser User { get; set; }

        public string MediaCategory { get; set; }

        public string ImageURL { get; set; }
    }
}
