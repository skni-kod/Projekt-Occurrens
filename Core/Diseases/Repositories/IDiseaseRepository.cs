using occurrensBackend.Entities.DatabaseEntities;

namespace Core.Diseases.Repositories;

public interface IDiseaseRepository
{
    Task<bool> AddDisease(Guid userId, Disease disease, CancellationToken cancellationToken);
}