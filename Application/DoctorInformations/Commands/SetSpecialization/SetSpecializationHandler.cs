using Application.Contracts.DoctorInformationsAnswers;
using Core.DataFromClaims.UserId;
using Core.DoctorInformations.Repositories;
using ErrorOr;
using MediatR;

namespace Application.DoctorInformations.Commands.SetSpecialization;

public class SetSpecializationHandler : IRequestHandler<SetSpecializationCommand, ErrorOr<DoctorInfoResponse>>
{
    private readonly IGetUserId _getUserId;
    private readonly IDoctorInfoRepository _doctorInfoRepository;

    public SetSpecializationHandler(IGetUserId getUserId, IDoctorInfoRepository doctorInfoRepository)
    {
        _getUserId = getUserId;
        _doctorInfoRepository = doctorInfoRepository;
    }
    
    public async Task<ErrorOr<DoctorInfoResponse>> Handle(SetSpecializationCommand request, CancellationToken cancellationToken)
    {
        var userId = _getUserId.UserId;
        
        await _doctorInfoRepository.SetSpecialization((Guid)userId, request.specialization, cancellationToken);

        return new DoctorInfoResponse("Utworzono nową specjalizację!");
    }
}