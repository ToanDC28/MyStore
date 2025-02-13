using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyStore.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Domain.Payments;
using Finbuckle.MultiTenant.EntityFrameworkCore;
using MyStore.Domain.Inventory;

namespace MyStore.Infrastructure.Persistence.Configuration;

public class PaymentConfig : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {

        builder
            .ToTable("Payment", SchemaNames.Payment)
            .IsMultiTenant();
    }
}

public class PaymentoutConfig : IEntityTypeConfiguration<Payout>
{
    public void Configure(EntityTypeBuilder<Payout> builder)
    {

        builder
            .ToTable("Payout", SchemaNames.Payment)
            .IsMultiTenant();

        builder
            .HasOne<Importation>()
            .WithOne()
            .HasForeignKey<Payout>(_ => _.ImportID);
    }
}
