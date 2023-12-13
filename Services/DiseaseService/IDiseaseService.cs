using occurrensBackend.Models.DiseaseModels;

namespace occurrensBackend.Services.DiseaseDoctorService;

public interface IDiseaseService
{
    public Guid CreateDisease(AddDiseaseModelDto dto);
}