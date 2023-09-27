using MecEnxovais.Domain.Entities;
using MecEnxovais.Infrastructure.EntityFrameworkExtensions;
using Microsoft.EntityFrameworkCore;

namespace MecEnxovais.Infrastructure.Context;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }

    public DbSet<StockMovement> StockMovements { get; set; }
    public DbSet<MovementInstalment> MovementInstalments { get; set; }
    public DbSet<MovementItem> MovementsItems { get; set; }

    public DbSet<FinancialMovement> FinancialMovements { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        ChangeTracker.SetAuditProperties();
        return await base.SaveChangesAsync(cancellationToken);
    }

    public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        ChangeTracker.SetAuditProperties();
        return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        ChangeTracker.SetAuditProperties();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    public override int SaveChanges()
    {
        ChangeTracker.SetAuditProperties();
        return base.SaveChanges();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        Company company = new Company("MecEnxovais");
        modelBuilder.Entity<Company>().HasData(company);
        modelBuilder.Entity<User>().HasData(new User("admin", "admin", "admin admin", "admin@admin.com", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", company.Id));
    }
}
