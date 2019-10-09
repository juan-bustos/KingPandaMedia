using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingPandaMedia.Models.Tables
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("Users")]
        public int UserID { get; set; }
        public virtual KPMUser User { get; set; }

        public string Category { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }
    }
}
