using FluentValidation;

namespace Application.DoctorInformations.Commands.SetOpenedData;

public class SetOpenedDataValidator : AbstractValidator<SetOpenedDataCommand>
{
    public SetOpenedDataValidator()
    {
        RuleFor(x => x.addressId)
            .NotNull().WithMessage("Nie wybrano żadnego gabinetu!");
    }
}