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
    
    public async Task SetSpecialization(Specialization specialization, CancellationToken cancellationToken)
    {
        await _context.AddAsync(specialization, cancellationToken);
        await _context.SaveChangesAsync();
    }

    public async Task SetAddress(Address address, CancellationToken cancellationToken)
    {
        await _context.Addresses.AddAsync(address, cancellationToken);
        await _context.SaveChangesAsync();
    }
}