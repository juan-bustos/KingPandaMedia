using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingPandaMedia.Models.Tables
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "First Name Required")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [StringLength(30)]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "E-Mail Required")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [StringLength(50)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SignUpDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Category { get; set; }
    }
}
