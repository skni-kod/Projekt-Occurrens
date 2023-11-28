using System.ComponentModel.DataAnnotations;

namespace occurrensBackend.Models.AboutDoctorModels
{
    public class AddressDto
    {
        [Required(ErrorMessage = "Podaj miejscowość")]
        public string Town { get; set; }


        public string? Street { get; set; }


        [Required(ErrorMessage = "Podaj numer domu")]
        public int Building_number { get; set; }


        public int? Apartament_number { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Nieprawidłowy kod pocztowy")]
        public string Postal_code { get; set; }



        [Required(ErrorMessage = "Podaj miasto")]
        public string City { get; set; }
    }
}
