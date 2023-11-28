using AutoMapper;
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
    }
}
