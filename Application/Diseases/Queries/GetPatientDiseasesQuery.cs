using Application.Contracts.DiseaseAnswer;
using ErrorOr;
using MediatR;

namespace Application.Diseases.Queries;

public record GetPatientDiseasesQuery(Guid PatientId) : IRequest<ErrorOr<GetPatientDiseasesResponse>>;