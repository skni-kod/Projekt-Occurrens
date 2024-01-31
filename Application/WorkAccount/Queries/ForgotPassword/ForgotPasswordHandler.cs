using Application.Common.Errors;
using Application.Contracts.AccountAnswer;
using Core.Account.DTOS;
using Core.Account.Repositories;
using MediatR;
using ErrorOr;

namespace Application.WorkAccount.Queries.ForgotPassword;

public class ForgotPasswordHandler : IRequestHandler<ForgotPasswordQuery, ErrorOr<AccountResponse>>
{
    private readonly IAccountRepository _accountRepository;

    public ForgotPasswordHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }
    
    public async Task<ErrorOr<AccountResponse>> Handle(ForgotPasswordQuery request, CancellationToken cancellationToken)
    {
        bool result = await _accountRepository.ForgotPasswordEmail(request.email, request.role, cancellationToken);

        if (result == false) return Errors.UserErrors.badEmail;

        return new AccountResponse("Sprawdź e-maila!");
    }
}