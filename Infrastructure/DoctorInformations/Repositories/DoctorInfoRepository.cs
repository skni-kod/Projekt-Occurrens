using Core.DoctorInformations.DTOS;
using Core.DoctorInformations.Extensions;
using Core.DoctorInformations.Repositories;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
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

    public async Task<AddressDto> GetAddress(Guid addressId, CancellationToken cancellationToken)
    {
        var address = await _context.Addresses.FindAsync(addressId, cancellationToken);
        
        if (address is null)
        {
            return null;
        }

        return address.AddressAsDto();
    }

    public async Task<bool> IsOpenedDataExists(Guid id, CancellationToken cancellationToken)
    {
        return await _context.IsOpeneds.AnyAsync(x => x.AddressId == id, cancellationToken);
    }

    public async Task CreateOpenedInfo(Is_opened isOpened, CancellationToken cancellationToken)
    {
        await _context.IsOpeneds.AddAsync(isOpened, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task<bool> UpdateSpecialization(Guid userId, Guid specializationId,string newSpecialization ,CancellationToken cancellationToken)
    {
        var result = await _context.Specializations.FindAsync(specializationId, cancellationToken);

        if (result != null && result.DoctorId == userId)
        {
            result.Specjalization = newSpecialization;
            
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }

        return false;
    }
}