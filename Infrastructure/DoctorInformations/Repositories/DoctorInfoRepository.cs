using Core.DoctorInformations.Repositories;
using Infrastructure.Persistance;
using occurrensBackend.Entities.DatabaseEntities;

namespace Infrastructure.DoctorInformations.Repositories;

public class DoctorInfoRepository : IDoctorInfoRepository
{
    private readonly OccurrensDbContext _context;

    public DoctorInfoRepository(OccurrensDbContext context)
    {
        _context = context;
    }
    
    public async Task SetSpecialization(Guid userId,string specialization, CancellationToken cancellationToken)
    {
        var result = new Specialization
        {
            DoctorId = userId,
            Specjalization = specialization
        };

        await _context.AddAsync(result, cancellationToken);
        await _context.SaveChangesAsync();
    }
}