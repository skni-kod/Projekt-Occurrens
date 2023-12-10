using occurrensBackend.Models.RegisterModels;

namespace occurrensBackend.Services.AccountService
{
    public interface IRegisterService
    {
        public Task RegisterDoctor(RegisterDoctorDto dto);

        public Task RegisterPatient(RegisterPatientDto dto);
    }
}