using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Core.Account.Repositories;
using Infrastructure.Persistance;
using occurrensBackend.Entities.DatabaseEntities;
using Core.Account.DTOS;
using Core.Account.enums;
using Core.Account.Extensions;
using Core.Date;
using Domain.AuthenticationSettings;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Account.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly OccurrensDbContext _context;
    private readonly AuthenticationSettings _authenticationSettings;
    private readonly IDateService _dateService;

    public AccountRepository(OccurrensDbContext context, AuthenticationSettings authenticationSettings, IDateService dateService)
    {
        _context = context;
        _authenticationSettings = authenticationSettings;
        _dateService = dateService;
    }
    
    public async Task<bool> IsEmailExist(string email, UserRoles role, CancellationToken cancellationToken)
    {
        if (role == UserRoles.Doctor)
        {
            var isExist = await _context.Doctors.AnyAsync(x => x.Email == email, cancellationToken);
            return isExist;
        }
        else if (role == UserRoles.Patient)
        {
            var isExist = await _context.Patients.AnyAsync(x => x.Email == email, cancellationToken);
            return isExist;
        }

        return false;
    }
    
    public async Task<AccountDto> UserData(string email,string password, UserRoles role, CancellationToken cancellationToken)
    {
        if (role == UserRoles.Doctor)
        {
            var doctor =  await _context.Doctors.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
            
            var passwordVerify = BCrypt.Net.BCrypt.Verify(password, doctor.Password);
            
            if (doctor is null || passwordVerify == false) return null;
            
            return doctor.DoctorAsDto();
        }
        else if (role == UserRoles.Patient)
        {
            var patient = await _context.Patients.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
            
            var passwordVerification = BCrypt.Net.BCrypt.Verify(password, patient.Password);
            
            if (patient is null || passwordVerification == false) return null;

            return patient.PatientAsDto();
        }

        return null;
    }

    public async Task<string> GenerateJwt(AccountDto data)
    {
        var claims = new List<Claim>()
        {
          new Claim(ClaimTypes.NameIdentifier, data.Id.ToString()),
          new Claim(ClaimTypes.Name, $"{data.Name} {data.Last_name}"),
          new Claim(ClaimTypes.Role, $"{data.Role}")
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
        var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expires = _dateService.CurrentDateTime().AddDays(_authenticationSettings.JwtExpireDays);

        var token = new JwtSecurityToken(
            _authenticationSettings.JwtIssuer,
            _authenticationSettings.JwtIssuer,
            claims,
            expires: expires,
            signingCredentials: cred
            );

        var tokenHandler = new JwtSecurityTokenHandler();
         

        return await Task.Run(() => tokenHandler.WriteToken(token));
    }

    public async Task<bool> VerifyPassword(string email, string password, UserRoles role, CancellationToken cancellationToken)
    {
        if (role == UserRoles.Doctor)
        {
            var doctor = await _context.Doctors.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
            return BCrypt.Net.BCrypt.Verify(password, doctor?.Password);
        }
        else if (role == UserRoles.Patient)
        {
            var patient = await _context.Patients.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
            return BCrypt.Net.BCrypt.Verify(password, patient?.Password);
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