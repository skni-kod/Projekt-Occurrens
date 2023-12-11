using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using occurrensBackend.Entities;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Exceptions;
using occurrensBackend.Models.AboutDoctorModels;
using occurrensBackend.Models.AboutDoctorModels.GetSelfInformationsDtos;
using occurrensBackend.Services.UserContextService;

namespace occurrensBackend.Services.DoctorInformationsService
{
    public class AboutDoctorService : IAboutDoctorService
    {
        private readonly DatabaseDbContext _context;
        private readonly IMapper _mapper;
        private readonly IUserContextService _userContextService;

        public AboutDoctorService(DatabaseDbContext context, IMapper mapper, IUserContextService userContextService)
        {
            _context = context;
            _mapper = mapper;
            _userContextService = userContextService;
        }

        public Guid AddSpecialization(SpecializationDto dto)
        {
            var userId = _userContextService.GetUserId;
            if (userId == null) 
            {
                throw new Exception("Nie istnieje ID");
            }

            var existingSpecialization = _context.Spetializations.FirstOrDefault(s => s.DoctorId == userId);

            if (existingSpecialization != null)
            {
                throw new SpecializationIsExisting("Nie możesz utworzyć nowej specjalizacji");
            }

            var specializationEntity = _mapper.Map<Spetialization>(dto);

            specializationEntity.DoctorId = userId;

            _context.Spetializations.Add(specializationEntity);
            _context.SaveChanges();

            return specializationEntity.Id;
        }


        public Guid AddAddress(AddressDto dto)
        {
            var addressEntity = _mapper.Map<Address>(dto);

            var userId = _userContextService.GetUserId;
            if (userId == null)
            {
                throw new Exception("Nie istnieje ID");
            }

            addressEntity.DoctorId = userId;

            _context.Addresses.Add(addressEntity);
            _context.SaveChanges(); 

            return addressEntity.Id;
        }

        public Guid AddIsOpened(Is_openedDto dto)
        {
            var userId = _userContextService.GetUserId;
            if (userId == null)
            {
                throw new Exception("Nie istnieje ID");
            }

            var findAddressId = _context.Addresses.FirstOrDefault(r => r.DoctorId == userId)?.Id;

            if (findAddressId == null)
            {
                throw new Exception("Nie istnieje taki adres");
            }

            var existingIsOpened = _context
                .Is_opened
                .FirstOrDefault(s => s.AddressId == findAddressId);

            if (existingIsOpened != null)
            {
                throw new BadRequestException("Nie możesz utworzyć nowych godzin otwarć");
            }

            var isOpenedEntity = _mapper.Map<Is_opened>(dto);
            isOpenedEntity.AddressId = findAddressId;

            _context.Is_opened.Add(isOpenedEntity);
            _context.SaveChanges();

            return isOpenedEntity.Id;
        }

        public void UpdateSpecialization(SpecializationUpdateDto dto)
        {
            var doctorId = _userContextService.GetUserId;

            var specialization = _context.Spetializations.FirstOrDefault(x => x.DoctorId == doctorId);

            if(specialization is null)
            {
                throw new NotFoundException("Nie posiadasz jeszcze żadnej specjalizacji!");
            }

            specialization.Specjalization = dto.Specjalization ?? specialization.Specjalization;

            _context.SaveChanges();
        }


        public void UpdateAddressAndIsOpened(AddressAndIsOpenedUpdateDto dto, Guid id)
        {
            var userId = _userContextService.GetUserId;

            var address = _context.Addresses.FirstOrDefault(x => x.DoctorId == userId && x.Id == id);
            var isOpened = _context.Is_opened.FirstOrDefault(x => x.AddressId == id);

            if(address is null)
            {
                throw new NotFoundException("Taki adres nie istnieje");
            }

            address.Town = dto.Town ?? address.Town;
            address.Street = dto.Street ?? address.Street;
            address.Building_number = dto.Building_number ?? address.Building_number;
            address.Apartament_number = dto.Apartament_number ?? address.Apartament_number;
            address.Postal_code = dto.Postal_code ?? address.Postal_code;
            address.City = dto.City ?? address.City;

            isOpened.Monday = dto.Monday ?? isOpened.Monday;
            isOpened.Tuesday = dto.Tuesday ?? isOpened.Tuesday;
            isOpened.Wednesday = dto.Wednesday ?? isOpened.Wednesday;
            isOpened.Thursday = dto.Thursday ?? isOpened.Thursday;
            isOpened.Fridady = dto.Fridady ?? isOpened.Fridady;
            isOpened.Saturday = dto.Saturday ?? isOpened.Saturday;
            isOpened.Sunday = dto.Sunday ?? isOpened.Sunday;
            
            _context.SaveChanges();
        }

        public BasicInformationsDto GetSelfInformations()
        {
            var userId = _userContextService.GetUserId;

            var doctor = _context.Doctors
                .Include(x => x.addresses)
                .ThenInclude(x => x.is_opened)
                .Include(x => x.spetializations)              
                .FirstOrDefault(x => x.Id == userId);

            if (doctor == null)
            {
                throw new NotFoundException("Zaloguj się!");
            }

            var result = _mapper.Map<BasicInformationsDto>(doctor);

            return result;
        }

    }
}
