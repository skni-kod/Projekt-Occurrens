using System.Data;
using FluentValidation;

namespace Application.WorkAccount.Commands.RegisterUser;

public class CreateUserValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserValidator()
    {
        RuleFor(x => x.Password)
            .Equal(e => e.ConfirmPassword).WithMessage("Hasła nie są równe!");

        RuleFor(x => x.Pesel)
            .NotEmpty().WithMessage("Podaj PESEL!")
            .Must(x => x.ToString().Length == 11).WithMessage("Podaj poprawny PESEL");

        RuleFor(x => x.Acception)
            .NotEmpty()
            .Equal(true).WithMessage("Zaakceptowanie przetwarzania danych jest wymagane!");

        RuleFor(x => x.TelNumber)
            .Must(x => x.ToString().Length == 9).WithMessage("Podaj poprawny numer telefonu");

        RuleFor(x => x.Role)
            .NotEmpty().WithMessage("Wybierz opcję rejestracji!")
            .IsInEnum().WithMessage("Niepoprawna rola!");
    }
}