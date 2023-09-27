using MecEnxovais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MecEnxovais.Infrastructure.EntitiesConfiguration;

public class FinancialMovementConfiguration : IEntityTypeConfiguration<FinancialMovement>
{
    public void Configure(EntityTypeBuilder<FinancialMovement> builder)
    {
        builder.HasKey(f => f.Id);
        builder.HasQueryFilter(f => !f.Deleted);
        builder.Property(f => f.AmountPaid).HasPrecision(10, 2);

        builder.HasOne(f => f.MovementInstalment).WithOne().HasForeignKey<FinancialMovement>(f => f.MovementInstalmentId);
        builder.HasOne(f => f.User).WithOne().HasForeignKey<FinancialMovement>(f => f.UserId).OnDelete(DeleteBehavior.NoAction);
    }
}
