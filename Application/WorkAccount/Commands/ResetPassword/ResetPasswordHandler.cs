using Application.Common.Errors;
using Application.Contracts.AccountAnswer;
using Core.Account.Repositories;
using MediatR;
using ErrorOr;

namespace Application.WorkAccount.Commands.ResetPassword;

public class ResetPasswordHandler : IRequestHandler<ResetPasswordCommand, ErrorOr<AccountResponse>>
{
    private readonly IAccountRepository _accountRepository;

    public ResetPasswordHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }
    
    public async Task<ErrorOr<AccountResponse>> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
    {
        bool result = await _accountRepository.ResetPassword(request.token, request.newPassword, request.role, cancellationToken);

        if (result == false) return Errors.UserErrors.somethinkWentWrong;

        return new AccountResponse("Pomyślnie zmieniono hasło!");
    }
}