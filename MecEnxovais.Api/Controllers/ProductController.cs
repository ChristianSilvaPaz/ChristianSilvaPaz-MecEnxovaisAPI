using MecEnxovais.Application.DTOs.Product;
using MecEnxovais.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MecEnxovais.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductServices _productServices;

    public ProductController(IProductServices productServices)
    {
        _productServices = productServices;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductResponseDTO>>> GetAsync()
    {
        return Ok(await _productServices.GetAsync());
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<ProductResponseDTO>> GetByIdAsync(Guid id)
    {
        var product = await _productServices.GetByIdAsync(id);

        return product is not null ? Ok(product) : BadRequest("Produto não encontrado");
    }

    [HttpPost]
    public async Task<ActionResult<ProductResponseDTO>> CreateAsync([FromBody] ProductCreateDTO productCreateDTO)
    {
        var product = await _productServices.CreateAsync(productCreateDTO);

        return Ok(product);
    }

    [HttpPut("{id:Guid}")]
    public async Task<ActionResult<ProductResponseDTO>> UpdateAsync(Guid id, [FromBody] ProductUpdateDTO productUpdateDTO)
    {
        var result = await _productServices.UpdateAsync(id, productUpdateDTO);

        return !result.Errors.Any() ? Ok(result.Data) : BadRequest(result.Errors);
    }

    [HttpDelete("{id:Guid}")]
    public async Task<ActionResult<ProductResponseDTO>> DeleteAsync(Guid id)
    {
        var result = await _productServices.DeleteAsync(id);

        return !result.Errors.Any() ? NoContent() : BadRequest(result.Errors);
    }
}

