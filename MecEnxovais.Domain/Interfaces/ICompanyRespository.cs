using MecEnxovais.Domain.Entities;

namespace MecEnxovais.Domain.Interfaces;

public interface ICompanyRespository
{
    Task<Company> CreateAsync(Company company);
}
