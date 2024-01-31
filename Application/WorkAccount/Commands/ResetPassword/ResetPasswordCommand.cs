using Application.Contracts.AccountAnswer;
using Core.Account.enums;
using MediatR;
using ErrorOr;

namespace Application.WorkAccount.Commands.ResetPassword;

public record ResetPasswordCommand(
    string token,
    string newPassword,
    string confirmPassword,
    UserRoles role
    ) : IRequest<ErrorOr<AccountResponse>>;