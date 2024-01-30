using Application.Contracts.AccountAnswer;
using Core.Account.enums;
using MediatR;
using ErrorOr;

namespace Application.WorkAccount.Queries.ConfirmAccount;

public record ConfirmAccountQuery(
    string token,
    string role,
    Guid id
    ) : IRequest<ErrorOr<AccountResponse>>;