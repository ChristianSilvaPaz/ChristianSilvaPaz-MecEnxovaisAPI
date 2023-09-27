using MecEnxovais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MecEnxovais.Infrastructure.EntitiesConfiguration;

public class StockMovementConfiguration : IEntityTypeConfiguration<StockMovement>
{
    public void Configure(EntityTypeBuilder<StockMovement> builder)
    {
        builder.HasKey(m => m.Id);
        builder.HasQueryFilter(m => !m.Deleted);
        builder.Property(m => m.TotalValue).HasPrecision(10, 2);
        builder.Property(m => m.Discount).HasPrecision(10, 2);
        builder.Property(m => m.Addition).HasPrecision(10, 2);

        builder.HasOne(m => m.User).WithOne().HasForeignKey<StockMovement>(m => m.UserId);
        builder.HasOne(m => m.Client).WithOne().HasForeignKey<StockMovement>(m => m.ClientId);
    }
}
