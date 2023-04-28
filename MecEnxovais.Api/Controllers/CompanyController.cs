using MecEnxovais.Application.DTOs.Company;
using MecEnxovais.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MecEnxovais.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class CompanyController : ControllerBase
{
    private readonly ICompanyServices _companyServices;

    public CompanyController(ICompanyServices companyServices)
    {
        _companyServices = companyServices;
    }

    [HttpPost]
    public async Task<ActionResult<CompanyResponseDTO>> CreateAsync([FromBody] CompanyCreateDTO companyCreateDTO)
    {
        var companny = await _companyServices.CreateAsync(companyCreateDTO);

        return Ok(companny);
    }
}
