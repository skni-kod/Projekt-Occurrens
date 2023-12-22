namespace occurrensBackend.Models.AboutDoctorModels.UpdateModels
{
    public class SelfInformationsUpdateDto
    {
        public string? Name { get; set; }
        public string? Secont_name { get; set; }
        public string? Last_name { get; set; }
        public int? Telephon_number { get; set; }
        public DateOnly? Date_of_birth { get; set; }
    }
}
