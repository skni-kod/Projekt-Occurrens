using System.ComponentModel.DataAnnotations;

namespace occurrensBackend.Models.AboutDoctorModels.UpdateModels
{
    public class AddressAndIsOpenedUpdateDto
    {
        public string? Town { get; set; }

        public string? Street { get; set; }

        public int? Building_number { get; set; }

        public int? Apartament_number { get; set; }

        [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Nieprawidłowy kod pocztowy")]
        public string? Postal_code { get; set; }

        public string? City { get; set; }

        public string? Monday { get; set; }

        public string? Tuesday { get; set; }

        public string? Wednesday { get; set; }

        public string? Thursday { get; set; }

        public string? Fridady { get; set; }

        public string? Saturday { get; set; }

        public string? Sunday { get; set; }

    }
}
