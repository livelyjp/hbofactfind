using System.ComponentModel.DataAnnotations;

namespace HboFactFind.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        public string Password { get; set; }
    }
}