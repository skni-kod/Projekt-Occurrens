using AutoMapper;
using occurrensBackend.Entities;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Exceptions;
using occurrensBackend.Models.DiseaseModels;
using occurrensBackend.Services.UserContextService;

namespace occurrensBackend.Services.DiseaseDoctorService;

public class DiseaseService : IDiseaseService
{
    private readonly IUserContextService _contextService;
    private readonly IMapper _mapper;
    private readonly DatabaseDbContext _dbContext;

    public DiseaseService(IUserContextService contextService, IMapper mapper, DatabaseDbContext dbContext)
    {
        _contextService = contextService;
        _mapper = mapper;
        _dbContext = dbContext;
    }
    
    
    public Guid CreateDisease(AddDiseaseModelDto dto)
    {
        var doctorId = _contextService.GetUserId;

        var patient = _dbContext.Patients.FirstOrDefault(x => x.Pesel == dto.Pesel);

        if (patient is null)
        {
            throw new NotFoundException("Podaj prawidłowy PESEL");
        }

        var disease = new Disease()
        {
            PatientId = patient.Id,
            CreatedByDoctor = (Guid)doctorId,
            Name = dto.Name,
            Description = dto.Desctiption,
            Medicines = dto.Medicines
        };

        _dbContext.Diseases.Add(disease);
        _dbContext.SaveChanges();

        return disease.Id;
    }
}