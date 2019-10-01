using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingPandaMedia.Models.Tables
{
    public class Portfolio
    {
        [Key]
        public int ImageID { get; set; }

        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }

        public string MediaCategory { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Image Url Required"), DataType(DataType.ImageUrl)]
        public string ImageURL { get; set; }
    }
}
