using Finbuckle.MultiTenant.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyStore.Domain.Identity;
using MyStore.Domain.Orders;
using MyStore.Domain.Payments;
using MyStore.Infrastructure.Identity;

namespace MyStore.Infrastructure.Persistence.Configuration;
public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder
            .ToTable("Users", SchemaNames.Identity)
            .IsMultiTenant();
    }
}

public class ApplicationRoleConfig : IEntityTypeConfiguration<ApplicationRole>
{
    public void Configure(EntityTypeBuilder<ApplicationRole> builder) =>
        builder
            .ToTable("Roles", SchemaNames.Identity)
            .IsMultiTenant()
                .AdjustUniqueIndexes();
}

public class ApplicationRoleClaimConfig : IEntityTypeConfiguration<ApplicationRoleClaim>
{
    public void Configure(EntityTypeBuilder<ApplicationRoleClaim> builder) =>
        builder
            .ToTable("RoleClaims", SchemaNames.Identity)
            .IsMultiTenant();
}

public class IdentityUserRoleConfig : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder) =>
        builder
            .ToTable("UserRoles", SchemaNames.Identity)
            .IsMultiTenant();
}

public class IdentityUserClaimConfig : IEntityTypeConfiguration<IdentityUserClaim<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder) =>
        builder
            .ToTable("UserClaims", SchemaNames.Identity)
            .IsMultiTenant();
}

public class IdentityUserLoginConfig : IEntityTypeConfiguration<IdentityUserLogin<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserLogin<string>> builder) =>
        builder
            .ToTable("UserLogins", SchemaNames.Identity)
            .IsMultiTenant();
}

public class IdentityUserTokenConfig : IEntityTypeConfiguration<IdentityUserToken<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserToken<string>> builder) =>
        builder
            .ToTable("UserTokens", SchemaNames.Identity)
            .IsMultiTenant();
}

public class SalaryUserConfig : IEntityTypeConfiguration<Salary>
{
    public void Configure(EntityTypeBuilder<Salary> builder)
    {

        builder
            .ToTable("Salary", SchemaNames.Identity)
            .IsMultiTenant();

        builder
            .HasOne<ApplicationUser>()
            .WithOne();

        builder
            .HasMany<HistoryOfSalary>()
            .WithOne().HasForeignKey(b => b.SalaryID);
    }
}

public class HistorySalaryUserConfig : IEntityTypeConfiguration<HistoryOfSalary>
{
    public void Configure(EntityTypeBuilder<HistoryOfSalary> builder)
    {

        builder
            .ToTable("HistorySalary", SchemaNames.Identity)
            .IsMultiTenant();

        builder
            .HasMany<ApplicationUser>()
            .WithOne();
    }
}

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {

        builder
            .ToTable("Customer", SchemaNames.Identity)
            .IsMultiTenant();

        builder
            .HasMany<Order>()
            .WithOne().HasForeignKey(b => b.CustomerID);

        builder
            .HasMany<Payment>()
            .WithOne()
            .HasForeignKey(_ => _.CustomerID);
    }
}