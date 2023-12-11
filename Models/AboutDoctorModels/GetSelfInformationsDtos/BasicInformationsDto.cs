namespace occurrensBackend.Models.AboutDoctorModels.GetSelfInformationsDtos
{
    public class BasicInformationsDto
    {
        public string Name { get; set; }
        public string Secont_name { get; set; } = string.Empty;
        public string Last_name { get; set; }
        public int Telephon_number { get; set; }
        public DateOnly Date_of_birth { get; set; }
        public string Specjalization { get; set; }

        public List<AddressInformationDto> AddressInformationDto { get; set; }
    }
}
