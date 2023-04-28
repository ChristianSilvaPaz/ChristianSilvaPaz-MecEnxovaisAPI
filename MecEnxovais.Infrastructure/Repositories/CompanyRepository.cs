using MecEnxovais.Domain.Entities;
using MecEnxovais.Domain.Interfaces;
using MecEnxovais.Infrastructure.Context;

namespace MecEnxovais.Infrastructure.Repositories;

public class CompanyRepository : ICompanyRespository
{
    private readonly ApplicationDbContext _context;

	public CompanyRepository(ApplicationDbContext context)
	{
		_context = context;
	}

    public async Task<Company> CreateAsync(Company company)
    {
        _context.Companies.Add(company);
        await _context.SaveChangesAsync();
        return company;
    }
}
