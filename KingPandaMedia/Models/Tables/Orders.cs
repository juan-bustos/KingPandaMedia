using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace KingPandaMedia.Models.Tables
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public string Category { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }
    }
}
