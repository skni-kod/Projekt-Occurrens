﻿using occurrensBackend.Models.AboutDoctorModels;
using occurrensBackend.Models.AboutDoctorModels.GetSelfInformationsDtos;

namespace occurrensBackend.Services.DoctorInformationsService
{
    public interface IAboutDoctorService
    {
        Guid AddSpecialization(SpecializationDto dto);

        public Guid AddAddress(AddressDto dto);

        public Guid AddIsOpened(Is_openedDto dto);

        public void UpdateSpecialization(SpecializationUpdateDto dto);

        public void UpdateAddressAndIsOpened(AddressAndIsOpenedUpdateDto dto, Guid id);

        public BasicInformationsDto GetSelfInformations();
    }
}