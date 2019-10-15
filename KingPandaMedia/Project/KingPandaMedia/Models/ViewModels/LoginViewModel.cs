using System.ComponentModel.DataAnnotations;

namespace KingPandaMedia.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }
        public string Username { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";

        public bool RememberMe { get; set; } = false;

    }
}
