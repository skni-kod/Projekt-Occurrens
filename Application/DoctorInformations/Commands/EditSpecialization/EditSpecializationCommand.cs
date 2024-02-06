using Application.Contracts.DoctorInformationsAnswers;
using ErrorOr;
using MediatR;

namespace Application.DoctorInformations.Commands.EditSpecialization;

public record EditSpecializationCommand(
    Guid id,
    string newSpecialization
    ) : IRequest<ErrorOr<DoctorInfoResponse>>;