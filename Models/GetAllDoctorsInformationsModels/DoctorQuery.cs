namespace occurrensBackend.Models.GetDoctorInformationsModels
{
    public class DoctorQuery
    {
        public string? SearchPhrase { get; set; }
        public int PageNumber { get; set; } = 0;
        public int PageSize { get; set; } = 0;
    }
}
