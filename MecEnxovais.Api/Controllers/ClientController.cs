using MecEnxovais.Application.DTOs.Client;
using MecEnxovais.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MecEnxovais.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class ClientController : ControllerBase
{
    private readonly IClientServices _clientServices;

    public ClientController(IClientServices clientServices)
    {
        _clientServices = clientServices;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ClientResponseDTO>>> GetAsync()
    {
        return Ok (await _clientServices.GetAsync());
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<ClientResponseDTO>> GetByIdAsync(Guid id)
    {
        var client = await _clientServices.GetByIdAsync(id);

        return client is not null ? Ok(client) : BadRequest("Cliente não encontrado");
    }

    [HttpPost]
    public async Task<ActionResult<ClientResponseDTO>> CreateAsync([FromBody] ClientCreateDTO clientCreateDTO)
    {
        var client = await _clientServices.CreateAsync(clientCreateDTO);

        return Ok(client);
    }

    [HttpPut("{id:Guid}")]
    public async Task<ActionResult<ClientResponseDTO>> UpdateAsync(Guid id, [FromBody] ClientUpdateDTO clientUpdateDTO)
    {
        var result = await _clientServices.UpdateAsync(id, clientUpdateDTO);

        return !result.Errors.Any() ? Ok(result.Data) : BadRequest(result.Errors);
    }

    [HttpDelete("{id:Guid}")]
    public async Task<ActionResult<ClientResponseDTO>> DeleteAsync(Guid id)
    {
        var result = await _clientServices.DeleteAsync(id);

        return !result.Errors.Any() ? NoContent() : BadRequest(result.Errors);
    }
}
