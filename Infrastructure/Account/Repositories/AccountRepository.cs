using Core.Account.Repositories;
using Infrastructure.Persistance;
using occurrensBackend.Entities.DatabaseEntities;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Account.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly OccurrensDbContext _context;

    public AccountRepository(OccurrensDbContext context)
    {
        _context = context;
    }
    
    public async Task<bool> IsEmailExist(string email, string role, CancellationToken cancellationToken)
    {
        if (role == "Doctor")
        {
            var isExist = await _context.Doctors.AnyAsync(x => x.Email == email, cancellationToken);
            return isExist;
        }
        else if (role == "Patient")
        {
            var isExist = await _context.Patients.AnyAsync(x => x.Email == email, cancellationToken);
            return isExist;
        }

        return false;
    }
    
    public async Task createDoctorAccount(Doctor doctor, CancellationToken cancellationToken)
    {
        var hashPassword = BCrypt.Net.BCrypt.HashPassword(doctor.Password);
        
        doctor.Password = hashPassword;
        
        await _context.Doctors.AddAsync(doctor, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task CreatePatientAccount(Patient patient, CancellationToken cancellationToken)
    {
        var hashPassword = BCrypt.Net.BCrypt.HashPassword(patient.Password);

        patient.Password = hashPassword;

        await _context.Patients.AddAsync(patient, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
}