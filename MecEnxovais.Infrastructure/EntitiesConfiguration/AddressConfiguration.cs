using MecEnxovais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MecEnxovais.Infrastructure.EntitiesConfiguration;
public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(a => a.Id);
        builder.HasQueryFilter(a => !a.Deleted);
        builder.Property(a => a.PublicPlace).HasMaxLength(100).IsRequired();
        builder.Property(a => a.Neighborhood).HasMaxLength(50).IsRequired();
        builder.Property(a => a.City).HasMaxLength(30).IsRequired();
        builder.Property(a => a.ZipCode).HasMaxLength(30).IsRequired();
        builder.Property(a => a.PointReference).HasMaxLength(100).IsRequired();
    }
}