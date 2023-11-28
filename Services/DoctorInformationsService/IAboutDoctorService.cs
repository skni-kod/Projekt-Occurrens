using occurrensBackend.Models.AboutDoctorModels;

namespace occurrensBackend.Services.DoctorInformationsService
{
    public interface IAboutDoctorService
    {
        Guid AddSpecialization(Guid doctorId, SpecializationDto dto);

        public Guid AddAddress(Guid doctorId, AddressDto dto);
    }
}