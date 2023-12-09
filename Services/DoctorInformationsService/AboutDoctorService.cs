using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using occurrensBackend.Entities;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Exceptions;
using occurrensBackend.Models.AboutDoctorModels;
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

    }
}
