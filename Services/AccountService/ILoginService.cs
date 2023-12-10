using occurrensBackend.Models.LoginModels;

namespace occurrensBackend.Services.AccountService
{
    public interface ILoginService
    {
        Task<string> GenerateDoctorJwt(LoginDto dto);
        Task<string> GeneratePatientJwt(LoginDto dto);
    }
}