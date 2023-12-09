using occurrensBackend.Models.AboutDoctorModels;

namespace occurrensBackend.Models.GetDoctorInformationsModels
{
    public class GetDoctorInformationsModelsDto
    {
        public string Name { get; set; }
        public string? Second_name { get; set; } = string.Empty;
        public string Last_name { get; set; }
        public string Specjalization { get; set; }
        public int Telephon_number { get; set; }

        public List<AddressesDto> Addresses { get; set; }

    }
}
