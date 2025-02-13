using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyStore.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Domain.Inventory;
using Finbuckle.MultiTenant.EntityFrameworkCore;
using MyStore.Domain.Orders;
using MyStore.Domain.Identity;
using MyStore.Domain.Payments;

namespace MyStore.Infrastructure.Persistence.Configuration;
public class ExportationConfig : IEntityTypeConfiguration<Exportation>
{
    public void Configure(EntityTypeBuilder<Exportation> builder)
    {
        builder
            .ToTable("Exportation", SchemaNames.Inventory)
            .IsMultiTenant();
    }
}

public class GoodsConfig : IEntityTypeConfiguration<Goods>
{
    public void Configure(EntityTypeBuilder<Goods> builder)
    {
        builder
            .ToTable("Goods", SchemaNames.Inventory)
            .IsMultiTenant();

        builder
            .HasMany<Exportation>()
            .WithOne()
            .HasForeignKey(b => b.GoodsID);

        builder
            .HasMany<Importation>()
            .WithOne()
            .HasForeignKey(b => b.GoodsID);
    }
}

public class ImportationConfig : IEntityTypeConfiguration<Importation>
{
    public void Configure(EntityTypeBuilder<Importation> builder)
    {
        builder
            .ToTable("Importation", SchemaNames.Inventory)
            .IsMultiTenant();
    }
}

public class SupplierConfig : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder
            .ToTable("Supplier", SchemaNames.Inventory)
            .IsMultiTenant();

        builder
            .HasMany<Goods>()
            .WithOne()
            .HasForeignKey(b => b.SupplierID);

        builder
            .HasMany<Importation>()
            .WithOne()
            .HasForeignKey(b => b.SupplierID);
    }
}

public class OrderConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder
            .ToTable("Order", SchemaNames.Inventory)
            .IsMultiTenant();

        builder
            .HasMany<Exportation>()
            .WithOne()
            .HasForeignKey(b => b.OrderID);

        builder
            .HasOne<Payment>()
            .WithOne()
            .HasForeignKey<Payment>(_ => _.OrderID);
    }
}