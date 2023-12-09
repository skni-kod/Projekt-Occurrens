using occurrensBackend.Models.LoginModels;

namespace occurrensBackend.Services.AccountService
{
    public interface ILoginService
    {
        Task<string> GenerateJwt(LoginDoctorDto dto);
    }
}