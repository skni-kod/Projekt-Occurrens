using FluentValidation;

namespace Application.DoctorInformations.Commands.EditSpecialization;

public class EditSpecializationValidator : AbstractValidator<EditSpecializationCommand>
{
    public EditSpecializationValidator()
    {
        RuleFor(x => x.id)
            .NotNull().NotEmpty().WithMessage("Nie wybrano specjalizacji do edycji!");

        RuleFor(x => x.newSpecialization)
            .NotNull().NotEmpty().WithMessage("Nie podałeś nowej specjalizacji!");
    }
}