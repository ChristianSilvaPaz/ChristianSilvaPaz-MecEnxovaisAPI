using MecEnxovais.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MecEnxovais.Infrastructure.EntitiesConfiguration;
public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(c => c.Id);
        builder.HasQueryFilter(c => !c.Deleted);
        builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
        builder.Property(c => c.PhoneNumber1).HasMaxLength(20).IsRequired();
        builder.Property(c => c.PhoneNumber2).HasMaxLength(20);
        builder.Property(c => c.Cpf).HasMaxLength(20).IsRequired();
        builder.Property(c => c.BirthDate).IsRequired();
        builder.Property(c => c.MaritalStatus).HasMaxLength(20).IsRequired();
        builder.Property(c => c.Sex).HasMaxLength(20).IsRequired();
        builder.Property(c => c.Rg).HasMaxLength(20).IsRequired();
        builder.Property(c => c.DispatchingAgency).HasMaxLength(20).IsRequired();
        builder.Property(c => c.ReferencePhone1).HasMaxLength(20).IsRequired();
        builder.Property(c => c.ReferencePhone2).HasMaxLength(20).IsRequired();
        builder.Property(c => c.ReferencePhone3).HasMaxLength(20);

        builder.HasOne(c => c.Address).WithOne(a => a.Client).HasForeignKey<Address>(a => a.ClientId);
    }
}
