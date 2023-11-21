using FluentValidation;
using occurrensBackend.Entities;

namespace occurrensBackend.Models.RegisterModels.Validators
{
    public class RegisterDoctorDtoValidator : AbstractValidator<RegisterDoctorDto>
    {
        public RegisterDoctorDtoValidator(DatabaseDbContext dbContext)
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();

            RuleFor(x => x.Password).MinimumLength(6);

            RuleFor(x => x.Repeat_password).Equal(e => e.Password).WithMessage("Hasła różnią się od siebie!");

            RuleFor(x => x.Email).Custom((value, context) =>
            {
                var emailIsUse = dbContext.Doctors.Any(u => u.Email == value);

                if(emailIsUse)
                {
                    context.AddFailure("E-mail", "Wprowadź inny adres e-mail!");
                }
            });

            RuleFor(x => x.Acception).Equal(true).WithMessage("Musisz zaakceptować przetwarzanie danych osobowych");

        }
    }
}
