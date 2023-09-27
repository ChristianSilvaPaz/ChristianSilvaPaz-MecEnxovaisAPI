using MecEnxovais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MecEnxovais.Infrastructure.EntitiesConfiguration;

public class MovementInstalmentConfiguration : IEntityTypeConfiguration<MovementInstalment>
{
    public void Configure(EntityTypeBuilder<MovementInstalment> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Id).HasDefaultValueSql("NEWID()");
        builder.HasQueryFilter(m => !m.Deleted);
        builder.Property(m => m.Value).HasPrecision(10, 2);

        builder.HasOne(m => m.StockMovement).WithOne().HasForeignKey<MovementInstalment>(m => m.StockMovementId);
    }
}
