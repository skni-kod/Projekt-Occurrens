using occurrensBackend.Models.RegisterModels;

namespace occurrensBackend.Services.AccountService
{
    public interface IRegisterService
    {
        void RegisterUser(RegisterDoctorDto dto);
    }
}