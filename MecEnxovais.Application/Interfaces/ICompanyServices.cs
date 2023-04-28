using MecEnxovais.Application.DTOs.Company;

namespace MecEnxovais.Application.Interfaces;

public interface ICompanyServices
{
    Task<CompanyResponseDTO> CreateAsync(CompanyCreateDTO company);
}
