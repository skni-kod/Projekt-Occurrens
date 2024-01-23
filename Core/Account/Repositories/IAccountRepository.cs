using occurrensBackend.Entities.DatabaseEntities;

namespace Core.Account.Repositories;

public interface IAccountRepository
{
    Task createDoctorAccount(Doctor doctor, CancellationToken cancellationToken);
    Task CreatePatientAccount(Patient patient, CancellationToken cancellationToken);
    Task<bool> IsEmailExist(string email, string role, CancellationToken cancellationToken);
}