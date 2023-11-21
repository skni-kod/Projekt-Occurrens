using System.ComponentModel.DataAnnotations;

namespace occurrensBackend.Models.RegisterModels
{
    public class RegisterDoctorDto
    {
        [Required(ErrorMessage = "Podaj imie!")]
        public string Name { get; set; }

        public string? Secont_name { get; set; }  = string.Empty;

        [Required(ErrorMessage ="Podaj nazwisko!")]
        public string Last_name { get; set; }

        [Required(ErrorMessage ="Podaj numer telefonu!")]
        public int Telephon_number { get; set; }

        [Required(ErrorMessage ="Podaj poprawny e-mail!")]
        public string Email {  get; set; }

        [Required(ErrorMessage ="Niepoprawne hasło!")]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        public string Repeat_password { get; set; }

        [Required(ErrorMessage ="Podaj datę urodzenia!")]
        public DateOnly Date_of_birth { get; set; }

        [Required(ErrorMessage ="Musisz zaakceptować przetwarzanie danych osobowych")]
        public bool Acception {  get; set; }
    }
}
