using Core.DoctorInformations.DTOS;
using occurrensBackend.Entities.DatabaseEntities;

namespace Core.DoctorInformations.Repositories;

public interface IDoctorInfoRepository
{
    Task SetSpecialization(Specialization specialization, CancellationToken cancellationToken);
    Task SetAddress(Address address, CancellationToken cancellationToken);
    Task<AddressDto> GetAddress(Guid addressId, CancellationToken cancellationToken);
    Task<bool> IsOpenedDataExists(Guid id, CancellationToken cancellationToken);
    Task CreateOpenedInfo(Is_opened isOpened, CancellationToken cancellationToken);
}