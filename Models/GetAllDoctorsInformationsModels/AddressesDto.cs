namespace occurrensBackend.Models.GetDoctorInformationsModels
{
    public class AddressesDto
    {
        public string Town { get; set; }
        public string? Street { get; set; } = string.Empty;
        public string Building_number { get; set; }
        public int? Apartament_number { get; set; }
        public string Postal_code { get; set; }
        public string City { get; set; }

        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Fridady { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; } 
    }
}
