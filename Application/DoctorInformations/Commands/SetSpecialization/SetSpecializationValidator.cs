using FluentValidation;

namespace Application.DoctorInformations.Commands.SetSpecialization;

public class SetSpecializationValidator : AbstractValidator<SetSpecializationCommand>
{
    public SetSpecializationValidator()
    {
        RuleFor(x => x.specialization)
            .NotEmpty().WithMessage("Nie możesz dodać pustej specjalizacji!");
    }
}