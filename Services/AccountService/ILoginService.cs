using occurrensBackend.Models.LoginModels;

namespace occurrensBackend.Services.AccountService
{
    public interface ILoginService
    {
        string GenerateJwt(LoginDoctorDto dto);
    }
}