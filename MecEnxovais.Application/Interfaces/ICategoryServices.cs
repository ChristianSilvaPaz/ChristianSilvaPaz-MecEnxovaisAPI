using MecEnxovais.Application.DTOs.Category;
using MecEnxovais.Application.Result;

namespace MecEnxovais.Application.Interfaces;
public interface ICategoryServices
{
    Task<IEnumerable<CategoryResponseDTO>> GetAsync();
    Task<CategoryResponseDTO> GetByIdAsync(Guid id);
    Task<CategoryResponseDTO> CreateAsync(CategoryCreateDTO category);
    Task<ServicesResult<CategoryResponseDTO>> UpdateAsync(Guid id, CategoryUpdateDTO category);
    Task<ServicesResult<CategoryResponseDTO>> DeleteAsync(Guid id);
}
