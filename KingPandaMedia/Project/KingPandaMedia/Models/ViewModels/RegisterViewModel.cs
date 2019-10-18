using System;
using System.ComponentModel.DataAnnotations;


namespace KingPandaMedia.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = " Enter a username"), StringLength(20)]
        public  string UserName { get; set; }

        [Required(ErrorMessage = "First Name Required"), StringLength(30)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required"), StringLength(30)]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "E-Mail Required")]
        public  string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number Required")]
        public  string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Required")]
        [StringLength(50)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [StringLength(50)]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime SignUpDate { get; set; }
    }
}
