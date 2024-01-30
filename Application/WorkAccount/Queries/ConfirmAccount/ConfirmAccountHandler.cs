using Application.Common.Errors;
using Application.Contracts.AccountAnswer;
using Core.Account.Repositories;
using MediatR;
using ErrorOr;

namespace Application.WorkAccount.Queries.ConfirmAccount;

public class ConfirmAccountHandler : IRequestHandler<ConfirmAccountQuery, ErrorOr<AccountResponse>>
{
    private readonly IAccountRepository _accountRepository;

    public ConfirmAccountHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }
    
    public async Task<ErrorOr<AccountResponse>> Handle(ConfirmAccountQuery request, CancellationToken cancellationToken)
    {
        bool response = await _accountRepository.ConfirmAccount(request.token, request.role, request.id);

        if (response == false)
        {
            return Errors.UserErrors.somethinkWentWrong;
        }

        return new AccountResponse("Pomyślnie zweryfikowano konto!");
    }
}