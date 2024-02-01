using occurrensBackend.Entities.DatabaseEntities;

namespace Core.DoctorInformations.Repositories;

public interface IDoctorInfoRepository
{
    Task SetSpecialization(Specialization specialization, CancellationToken cancellationToken);
    Task SetAddress(Address address, CancellationToken cancellationToken);
}