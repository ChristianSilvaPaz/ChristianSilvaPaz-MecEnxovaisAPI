using MecEnxovais.Application.DTOs.StockMovement;
using MecEnxovais.Application.Interfaces;
using MecEnxovais.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MecEnxovais.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class StockMovementControllerController : ControllerBase
{
    private readonly IStockMovementServices _stockMovementServices;

    public StockMovementControllerController(IStockMovementServices stockMovementServices)
    {
        _stockMovementServices = stockMovementServices;
    }

    [HttpPost]
    public async Task<ActionResult> CreateAsync([FromBody] StockMovementCreateDTO stockMovementCreateDTO)
    {
        var movement = await _stockMovementServices.CreateAsync(stockMovementCreateDTO);

        return Ok();
    }

}
