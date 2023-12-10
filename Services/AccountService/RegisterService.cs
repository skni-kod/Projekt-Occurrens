using Microsoft.AspNetCore.Identity;
using occurrensBackend.Entities;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Models.RegisterModels;

namespace occurrensBackend.Services.AccountService
{
    public class RegisterService : IRegisterService
    {
        private readonly DatabaseDbContext _context;
        private readonly IPasswordHasher<Doctor> _passwordDoctorHasher;
        private readonly IPasswordHasher<Patient> _passwordPatientHasher;

        public RegisterService(DatabaseDbContext context, IPasswordHasher<Doctor> passwordDoctorHasher, IPasswordHasher<Patient> passwordPatientHasher)
        {
            _context = context;
            _passwordDoctorHasher = passwordDoctorHasher;
            _passwordPatientHasher = passwordPatientHasher;
        }

        public async Task RegisterDoctor(RegisterDoctorDto dto)
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

            var hashedPassword = _passwordDoctorHasher.HashPassword(newDoctor, dto.Password);

            newDoctor.Password = hashedPassword;

            _context.Doctors.Add(newDoctor);
            _context.SaveChanges();
        }

        public async Task RegisterPatient(RegisterPatientDto dto)
        {
            var newPatient = new Patient()
            {
                Pesel = dto.Pesel,
                Name = dto.Name,
                Secont_name = dto.Secont_name,
                Last_name = dto.Last_name,
                Telephon_number = dto.Telephon_number,
                Email = dto.Email,
                Date_of_birth=dto.Date_of_birth,
                Acceptation = dto.Acception
            };

            var hashedPassword = _passwordPatientHasher.HashPassword(newPatient, dto.Password);

            newPatient.Password = hashedPassword;

            _context.Patients.Add(newPatient);
            _context.SaveChanges();
        }
    }
}
