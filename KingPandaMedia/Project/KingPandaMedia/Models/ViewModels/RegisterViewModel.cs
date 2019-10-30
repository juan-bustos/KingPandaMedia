using System;
using System.ComponentModel.DataAnnotations;
using KingPandaMedia.Models.ViewModels;


namespace KingPandaMedia.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = " Enter a username"), StringLength(20)]
        [Display(Name = "Username")]
        public  string UserName { get; set; }

        [Required(ErrorMessage = "First Name Required"), StringLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required"), StringLength(30)]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "E-Mail Required")]
        public  string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
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

        public LoginViewModel LoginViewModel { get; set; }
    }
}
