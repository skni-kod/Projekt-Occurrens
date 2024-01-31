using System.Data;
using FluentValidation;

namespace Application.WorkAccount.Commands.ResetPassword;

public class ResetPasswordValidator : AbstractValidator<ResetPasswordCommand>
{
    public ResetPasswordValidator()
    {
        RuleFor(x => x.token)
            .NotEmpty().WithMessage("Coś poszło nie tak!");

        RuleFor(x => x.newPassword)
            .Equal(e => e.confirmPassword)
            .WithMessage("Hasła się różnią!");

        RuleFor(x => x.role)
            .IsInEnum().WithMessage("Niepoprawna rola!");
    }
}