using occurrensBackend.Models.AboutDoctorModels;

namespace occurrensBackend.Services.DoctorInformationsService
{
    public interface IAboutDoctorService
    {
        Guid AddSpecialization(SpecializationDto dto);

        public Guid AddAddress(AddressDto dto);

        public Guid AddIsOpened(Is_openedDto dto);

        public void UpdateSpecialization(SpecializationUpdateDto dto);

        public void UpdateAddressAndIsOpened(AddressAndIsOpenedUpdateDto dto, Guid id);
    }
}