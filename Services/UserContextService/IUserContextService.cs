using System.Security.Claims;

namespace occurrensBackend.Services.UserContextService
{
    public interface IUserContextService
    {
        Guid? GetUserId { get; }
        ClaimsPrincipal User { get; }
    }
}