using System.ComponentModel.DataAnnotations;

namespace HboFactFind.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}