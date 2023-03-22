using MecEnxovais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MecEnxovais.Infrastructure.EntitiesConfiguration;
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        builder.HasQueryFilter(u => !u.Deleted);
        builder.Property(u => u.FirstName).HasMaxLength(50).IsRequired();
        builder.Property(u => u.LastName).HasMaxLength(50).IsRequired();
        builder.Property(u => u.FullName).HasMaxLength(100).IsRequired();
        builder.Property(u => u.Email).HasMaxLength(100).IsRequired();
        builder.Property(u => u.Password).HasMaxLength(300).IsRequired();
        builder.HasOne(u => u.Company).WithMany(c => c.Users).HasForeignKey(u => u.CompanyId).OnDelete(DeleteBehavior.Restrict);
    }
}
