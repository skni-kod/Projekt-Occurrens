using Core.Account.DTOS;
using Core.Account.enums;
using occurrensBackend.Entities.DatabaseEntities;

namespace Core.Account.Repositories;

public interface IAccountRepository
{
    Task createDoctorAccount(Doctor doctor, CancellationToken cancellationToken);
    Task CreatePatientAccount(Patient patient, CancellationToken cancellationToken);
    Task<bool> IsEmailExist(string email, UserRoles role, CancellationToken cancellationToken);
    Task<AccountDto> UserData(string email,string password,UserRoles role, CancellationToken cancellationToken);
    Task<string> GenerateJwt(AccountDto data);
}