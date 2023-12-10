using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using occurrensBackend.Entities;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Exceptions;
using occurrensBackend.Models.LoginModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace occurrensBackend.Services.AccountService
{
    public class LoginService : ILoginService
    {
        private readonly DatabaseDbContext _context;
        private readonly IPasswordHasher<Doctor> _passwordDoctorHasher;
        private readonly IPasswordHasher<Patient> _passwordPatientHasher;
        private readonly AuthenticationSettings _authenticationSettings;

        public LoginService(DatabaseDbContext context, IPasswordHasher<Doctor> passwordDoctorHasher,IPasswordHasher<Patient> passwordPatientHasher, AuthenticationSettings authenticationSettings)
        {
            _context = context;
            _passwordDoctorHasher = passwordDoctorHasher;
            _passwordPatientHasher = passwordPatientHasher;
            _authenticationSettings = authenticationSettings;
        }


        public async Task<string> GenerateDoctorJwt(LoginDto dto)
        {
            var doctor = _context.Doctors
                .FirstOrDefault(u => u.Email == dto.Email);

            if (doctor is null)
            {
                throw new BadRequestException("Niepoprawny e-mail lub hasło!");
            }

            var result = _passwordDoctorHasher.VerifyHashedPassword(doctor, doctor.Password, dto.Password);

            if (result == PasswordVerificationResult.Failed)
            {
                throw new BadRequestException("Niepoprawny e-mail lub hasło!");
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, doctor.Id.ToString()),
                new Claim(ClaimTypes.Name, $"{doctor.Name} {doctor.Last_name}"),
                new Claim(ClaimTypes.Role, $"{doctor.Role}"),
                new Claim("DateOfBirth", doctor.Date_of_birth.ToString("yyyy-MM-dd")),
            };

            if(!string.IsNullOrEmpty(doctor.Secont_name))
            {
                claims.Add(new Claim("SecontName", $"{doctor.Secont_name}"));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays);

            var token = new JwtSecurityToken(_authenticationSettings.JwtIssuer,
                _authenticationSettings.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: cred);


            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }


        public async Task<string> GeneratePatientJwt(LoginDto dto)
        {
            var patient = _context.Patients
                .FirstOrDefault(x => x.Email == dto.Email);

            if(patient is null)
            {
                throw new BadRequestException("Niepoprawny e-mail lub hasło!");
            }

            var result = _passwordPatientHasher.VerifyHashedPassword(patient, patient.Password, dto.Password);

            if(result == PasswordVerificationResult.Failed)
            {
                throw new BadRequestException("Niepoprawny e-mail lub hasło!");
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, patient.Id.ToString()),
                new Claim(ClaimTypes.Name, $"{patient.Name} {patient.Last_name}"),
                new Claim(ClaimTypes.Role, $"{patient.Role}"),
                new Claim("DateOfBirth", patient.Date_of_birth.ToString("yyyy-MM-dd")),
            };

            if(!string.IsNullOrEmpty(patient.Secont_name))
            {
                claims.Add(new Claim("SecontName", $"{patient.Secont_name}"));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays);

            var token = new JwtSecurityToken(_authenticationSettings.JwtIssuer,
                _authenticationSettings.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: cred);

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }
    }
}
