using MecEnxovais.Application.DTOs.Category;
using MecEnxovais.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MecEnxovais.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class CategoryController : ControllerBase
{
    private readonly ICategoryServices _categoryServices;

    public CategoryController(ICategoryServices categoryServices)
    {
        _categoryServices = categoryServices;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoryResponseDTO>>> Get()
    {
        return Ok(await _categoryServices.GetAsync());
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<CategoryResponseDTO>> GetByIdAsync(Guid id)
    {
        var category = await _categoryServices.GetByIdAsync(id);

        return category is not null ? Ok(category) : BadRequest("Categoria não encontrada");
    }

    [HttpPost]
    public async Task<ActionResult<CategoryResponseDTO>> CreateCategory([FromBody] CategoryCreateDTO categoryCreateDTO)
    {
        var category = await _categoryServices.CreateAsync(categoryCreateDTO);

        return Ok(category);
    }

    [HttpPut("{id:Guid}")]
    public async Task<ActionResult<CategoryResponseDTO>> Update(Guid id, [FromBody] CategoryUpdateDTO categoryUpdateDTO)
    {
        var result = await _categoryServices.UpdateAsync(id, categoryUpdateDTO);

        return !result.Errors.Any() ? Ok(result.Data) : BadRequest(result.Errors);
    }

    [HttpDelete("{id:Guid}")]
    public async Task<ActionResult<CategoryResponseDTO>> Delete(Guid id)
    {
        var result = await _categoryServices.DeleteAsync(id);

        return !result.Errors.Any() ? NoContent() : BadRequest(result.Errors);
    }
}
