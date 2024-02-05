using Core.DoctorInformations.DTOS;
using occurrensBackend.Entities.DatabaseEntities;

namespace Core.DoctorInformations.Extensions;

public static class Extensions
{
    public static AddressDto AddressAsDto(this Address address)
    {
        return new AddressDto
        {
            DoctorId = (Guid)address.DoctorId,
            Id = address.Id,
            Street = address.Street,
            Building_number = address.Building_number,
            Apartament_number = (int)address.Apartament_number,
            Postal_code = address.Postal_code,
            City = address.City,
        };
    }
}