using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using occurrensBackend.Entities;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Exceptions;
using occurrensBackend.Models.AboutDoctorModels;

namespace occurrensBackend.Services.DoctorInformationsService
{
    public class AboutDoctorService : IAboutDoctorService
    {
        private readonly DatabaseDbContext _context;
        private readonly IMapper _mapper;

        public AboutDoctorService(DatabaseDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Guid AddSpecialization(Guid doctorId, SpecializationDto dto)
        {
            var existingSpecialization = _context.Spetializations.FirstOrDefault(s => s.DoctorId == doctorId);

            if (existingSpecialization != null)
            {
                throw new SpecializationIsExisting("Nie możesz utworzyć nowej specjalizacji");
            }

            var specializationEntity = _mapper.Map<Spetialization>(dto);

            specializationEntity.DoctorId = doctorId;

            _context.Spetializations.Add(specializationEntity);
            _context.SaveChanges();

            return specializationEntity.Id;
        }


        public Guid AddAddress(Guid doctorId, AddressDto dto)
        {
            var addressEntity = _mapper.Map<Address>(dto);

            addressEntity.DoctorId = doctorId;

            _context.Addresses.Add(addressEntity);
            _context.SaveChanges(); 

            return addressEntity.Id;
        }

        public Guid AddIsOpened(Guid doctorId, Is_openedDto dto, Guid addressId)
        {
            var test = _context
                .Addresses
                .Any(r => r.DoctorId == doctorId && r.Id == addressId);

            var existingIsOpened = _context
                .Is_opened
                .FirstOrDefault(s => s.AddressId == addressId);

            if (!test || existingIsOpened != null)
            {
                throw new BadRequestException("Nie możesz utworzyć nowej specjalizacji");
            }

            var isOpenedEntity = _mapper.Map<Is_opened>(dto);
            isOpenedEntity.AddressId = addressId;

            _context.Is_opened.Add(isOpenedEntity);
            _context.SaveChanges();

            return isOpenedEntity.Id;
        }

    }
}
