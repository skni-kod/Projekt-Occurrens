using Microsoft.AspNetCore.Identity;
using occurrensBackend.Entities;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Models.RegisterModels;

namespace occurrensBackend.Services.AccountService
{
    public class RegisterService : IRegisterService
    {
        private readonly DatabaseDbContext _context;
        private readonly IPasswordHasher<Doctor> _passwordHasher;

        public RegisterService(DatabaseDbContext context, IPasswordHasher<Doctor> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public void RegisterUser(RegisterDoctorDto dto)
        {
            var newDoctor = new Doctor()
            {
                Name = dto.Name,
                Secont_name = dto.Secont_name,
                Last_name = dto.Last_name,
                Telephon_number = dto.Telephon_number,
                Email = dto.Email,
                Date_of_birth = dto.Date_of_birth,
                Acception = dto.Acception,
            };

            var hashedPassword = _passwordHasher.HashPassword(newDoctor, dto.Password);

            newDoctor.Password = hashedPassword;

            _context.Doctors.Add(newDoctor);
            _context.SaveChanges();
        }
    }
}
