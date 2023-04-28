using MecEnxovais.Application.Interfaces;
using MecEnxovais.Application.Mappings;
using MecEnxovais.Application.Services;
using MecEnxovais.Domain.Interfaces;
using MecEnxovais.Infrastructure.Auth;
using MecEnxovais.Infrastructure.Context;
using MecEnxovais.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MecEnxovais.CrossCutting;
public static class DependencyInjection
{
    public static IServiceCollection AddDependenciesInjections(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
         options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b =>
            b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

        services.AddScoped<ICategoryServices, CategoryServices>();
        services.AddScoped<IProductServices, ProductServices>();
        services.AddScoped<IClientServices, ClientServices>();
        services.AddScoped<IUserServices, UserServices>();
        services.AddScoped<IAuthServices, AuthServices>();
        services.AddScoped<ILoginServices, LoginServices>();
        services.AddScoped<ICompanyServices, CompanyServices>();

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IClientRepository, ClientRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ICompanyRespository, CompanyRepository>();

        return services;
    }
}
