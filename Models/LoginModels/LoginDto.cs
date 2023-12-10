using System.ComponentModel.DataAnnotations;

namespace occurrensBackend.Models.LoginModels
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Podaj e-mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Podaj hasło!")]
        public string Password { get; set; }
    }
}
