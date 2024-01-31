using Application.Contracts.AccountAnswer;
using MediatR;
using ErrorOr;

namespace Application.WorkAccount.Queries.GenerateTokenToResetPassword;

public record GenerateTokenToResetPasswordCommand(
    Guid id,
    string role
    ) : IRequest<ErrorOr<AccountResponse>>;