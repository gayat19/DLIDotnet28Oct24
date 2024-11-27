using FirstAPiApp.Misc;
using System.ComponentModel.DataAnnotations;

namespace FirstAPiApp.Models.DTOs
{
    
    public class LoginRequestDTO
    {
  
        [Required(AllowEmptyStrings =false,ErrorMessage ="Username cannot be empty")]
        [RegularExpression("[a-z0-9]+@[a-z]+\\.[a-z]{2,3}",ErrorMessage ="Inavlid email for username")]
        //[UsernameValidator]
        public string Username { get; set; } = string.Empty;
        [MinLength(3,ErrorMessage ="Password too small")]
        public string Password { get; set; } = string.Empty;
    }
}
