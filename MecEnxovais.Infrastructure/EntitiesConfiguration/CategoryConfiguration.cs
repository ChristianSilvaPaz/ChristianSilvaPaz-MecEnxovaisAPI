using MecEnxovais.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MecEnxovais.Infrastructure.EntitiesConfiguration;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        builder.HasQueryFilter(c => !c.Deleted);
        builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
    }
}
