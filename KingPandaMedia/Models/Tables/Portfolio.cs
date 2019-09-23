using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace KingPandaMedia.Models.Tables
{
    public class Portfolio
    {
        [Key]
        public int ImageID { get; set; }

        [ForeignKey("EmployeeID")]
        public virtual Employees Employee { get; set; }

        public string MediaCategory { get; set; }

        [Required(ErrorMessage = "Image Url Required")]
        [StringLength(100)]
        public string ImageURL { get; set; }
    }
}
