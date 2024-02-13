using Core.Diseases.Repositories;
using Infrastructure.Persistance;
using occurrensBackend.Entities.DatabaseEntities;

namespace Infrastructure.Diseases.Repositories;

public class DiseaseRepository : IDiseaseRepository
{
    private readonly OccurrensDbContext _context;

    public DiseaseRepository(OccurrensDbContext context)
    {
        _context = context;
    }
    
    public async Task<bool> AddDisease(Guid userId, Disease disease, CancellationToken cancellationToken)
    {
        var isPatientExist = await _context.Patients.FindAsync(disease.PatientId, cancellationToken);

        if (isPatientExist is null) return false;

        await _context.Diseases.AddAsync(disease, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}