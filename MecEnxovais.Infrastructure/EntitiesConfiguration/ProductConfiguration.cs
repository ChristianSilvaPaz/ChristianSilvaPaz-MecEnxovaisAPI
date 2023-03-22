using MecEnxovais.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MecEnxovais.Infrastructure.EntitiesConfiguration;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasQueryFilter(p => !p.Deleted);
        builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
        builder.Property(p => p.Price).HasPrecision(10, 2);

        builder.HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);
    }
}
