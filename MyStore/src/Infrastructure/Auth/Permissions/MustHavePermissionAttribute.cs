using Microsoft.AspNetCore.Authorization;
using MyStore.Shared.Authorization;

namespace MyStore.Infrastructure.Auth.Permissions;
public class MustHavePermissionAttribute : AuthorizeAttribute
{
    public MustHavePermissionAttribute(string action, string resource) =>
        Policy = FSHPermission.NameFor(action, resource);
}