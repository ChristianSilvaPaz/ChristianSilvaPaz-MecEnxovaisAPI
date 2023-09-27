using MecEnxovais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MecEnxovais.Infrastructure.EntitiesConfiguration;

public class MovementItemConfiguration : IEntityTypeConfiguration<MovementItem>
{
    public void Configure(EntityTypeBuilder<MovementItem> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Id).HasDefaultValueSql("NEWID()");
        builder.HasQueryFilter(m => !m.Deleted);
        builder.Property(m => m.TotalValue).HasPrecision(10, 2);
        builder.Property(m => m.UnitaryValue).HasPrecision(10, 2);
        builder.Property(m => m.Discount).HasPrecision(10, 2);
        builder.Property(m => m.Addition).HasPrecision(10, 2);

        builder.HasOne(m => m.Product).WithOne().HasForeignKey<MovementItem>(m => m.ProductId);
        builder.HasOne(m => m.StockMovement).WithMany(x => x.MovementsItems).HasForeignKey(m => m.StockMovementId).OnDelete(DeleteBehavior.Restrict);
    }
}