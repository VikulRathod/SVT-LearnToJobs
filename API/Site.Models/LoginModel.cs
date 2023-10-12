using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please Enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
    }
}
