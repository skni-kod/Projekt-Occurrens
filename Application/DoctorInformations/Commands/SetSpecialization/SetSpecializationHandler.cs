using Application.Contracts.DoctorInformationsAnswers;
using ErrorOr;
using MediatR;

namespace Application.DoctorInformations.Commands.SetSpecialization;

public class SetSpecializationHandler : IRequestHandler<SetSpecializationCommand, ErrorOr<DoctorInfoResponse>>
{
    public Task<ErrorOr<DoctorInfoResponse>> Handle(SetSpecializationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}