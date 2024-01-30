using Core.Account.DTOS;

namespace Core.Account.Repositories;

public interface IEmailService
{
    void SendEmail(EmailDto request);
}