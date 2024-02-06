using Application.Common.Errors;
using Application.Contracts.DoctorInformationsAnswers;
using Core.DataFromClaims.UserId;
using Core.DoctorInformations.Repositories;
using ErrorOr;
using MediatR;

namespace Application.DoctorInformations.Commands.EditSpecialization;

public class EditSpecializationHandler : IRequestHandler<EditSpecializationCommand, ErrorOr<DoctorInfoResponse>>
{
    private readonly IGetUserId _getUserId;
    private readonly IDoctorInfoRepository _doctorInfoRepository;


    public EditSpecializationHandler(IGetUserId getUserId, IDoctorInfoRepository doctorInfoRepository)
    {
        _getUserId = getUserId;
        _doctorInfoRepository = doctorInfoRepository;
    }

    public async Task<ErrorOr<DoctorInfoResponse>> Handle(EditSpecializationCommand request, CancellationToken cancellationToken)
    {
        var userId = _getUserId.UserId;

        var specializationToUpdate = await _doctorInfoRepository.UpdateSpecialization((Guid)userId, request.id, request.newSpecialization, cancellationToken);

        if (!specializationToUpdate) return Errors.Permision.permissionDenied;

        return new DoctorInfoResponse("Zaktualizowano!");
    }
}