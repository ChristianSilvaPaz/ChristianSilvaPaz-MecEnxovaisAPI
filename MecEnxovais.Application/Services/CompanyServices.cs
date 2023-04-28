using AutoMapper;
using MecEnxovais.Application.DTOs.Company;
using MecEnxovais.Application.Interfaces;
using MecEnxovais.Domain.Entities;
using MecEnxovais.Domain.Interfaces;

namespace MecEnxovais.Application.Services;
public class CompanyServices : ICompanyServices
{
    private readonly ICompanyRespository _companyRespository;
    private readonly IMapper _mapper;

    public CompanyServices(ICompanyRespository companyRespository, IMapper mapper)
    {
        _companyRespository = companyRespository;
        _mapper = mapper;
    }

    public async Task<CompanyResponseDTO> CreateAsync(CompanyCreateDTO company)
    {
        var companyEntity = new Company(company.Name);

        await _companyRespository.CreateAsync(companyEntity);   
        return _mapper.Map<CompanyResponseDTO>(companyEntity);
    }
}
