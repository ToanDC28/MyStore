using System.Security.Claims;

namespace MyStore.Infrastructure.Auth;
public interface ICurrentUserInitializer
{
    void SetCurrentUser(ClaimsPrincipal user);

    void SetCurrentUserId(string userId);
}