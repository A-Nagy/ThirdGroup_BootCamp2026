using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ThirdGroup_1.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(50)]
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; } = false; 
    }
}
