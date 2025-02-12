using System.Collections.ObjectModel;

namespace MyStore.Shared.Authorization;
public static class FSHRoles
{
    public const string Admin = nameof(Admin);
    public const string Accountant = nameof(Accountant);
    public const string Employee = nameof(Employee);
    public static IReadOnlyList<string> DefaultRoles { get; } = new ReadOnlyCollection<string>(new[]
    {
        Admin,
        Accountant,
        Employee,
    });

    public static bool IsDefault(string roleName) => DefaultRoles.Any(r => r == roleName);
}