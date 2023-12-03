using occurrensBackend.Models.GetDoctorInformationsModels;

namespace occurrensBackend.Services.ShowAllDoctorsService
{
    public interface IShowAllDoctorsService
    {
        PagedResult<GetDoctorInformationsModelsDto> GetAllDoctors(DoctorQuery query);
    }
}