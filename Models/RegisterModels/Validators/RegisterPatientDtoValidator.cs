using FluentValidation;
using occurrensBackend.Entities;

namespace occurrensBackend.Models.RegisterModels.Validators
{
    public class RegisterPatientDtoValidator : AbstractValidator<RegisterPatientDto>
    {
        public RegisterPatientDtoValidator(DatabaseDbContext dbContext)
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();

            RuleFor(x => x.Password).MinimumLength(6);

            RuleFor(x => x.Repeat_password).Equal(e => e.Password).WithMessage("Hasła różnią się od siebie!");

            RuleFor(x => x.Pesel.ToString()).Length(11).WithMessage("Niepoprawny PESEL!");

            RuleFor(x => x.Email).Custom((value, context) =>
            {
                var emailIsUsed = dbContext.Patients.Any(u => u.Email == value);

                if (emailIsUsed)
                {
                    context.AddFailure("E-mail", "Wprowadź inny e-mail");
                }
            });

            RuleFor(x => x.Acception).Equal(true).WithMessage("Musisz zaakceptować przetwarzanie danych osobowych");
        }
    }
}
