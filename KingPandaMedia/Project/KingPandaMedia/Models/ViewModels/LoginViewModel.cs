using System.ComponentModel.DataAnnotations;

namespace KingPandaMedia.Models.ViewModels
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "E-Mail Required")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [StringLength(50)]
        public string Password { get; set; }

        [Display(Name ="Remember login")]
        public bool RememberLogin { get; set; }
    }
}
