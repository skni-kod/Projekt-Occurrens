namespace Core.DoctorInformations.Repositories;

public interface IDoctorInfoRepository
{
    Task SetSpecialization(Guid userId,string specialization, CancellationToken cancellationToken);
}