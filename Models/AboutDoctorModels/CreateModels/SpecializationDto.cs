using System.ComponentModel.DataAnnotations;

namespace occurrensBackend.Models.AboutDoctorModels.CreateModels
{
    public class SpecializationDto
    {
        [Required(ErrorMessage = "Pole specjalizacji jest puste")]
        public string Specjalization { get; set; }
    }
}
