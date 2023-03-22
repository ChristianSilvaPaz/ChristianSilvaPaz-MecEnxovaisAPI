using AutoMapper;
using MecEnxovais.Application.DTOs.Category;
using MecEnxovais.Application.Interfaces;
using MecEnxovais.Application.Result;
using MecEnxovais.Domain.Entities;
using MecEnxovais.Domain.Interfaces;

namespace MecEnxovais.Application.Services;
public class CategoryServices : ICategoryServices
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryServices(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CategoryResponseDTO>> GetAsync()
    {
        var categoriesEntity = await _categoryRepository.GetAsync();
        return _mapper.Map<IEnumerable<CategoryResponseDTO>>(categoriesEntity);
    }

    public async Task<CategoryResponseDTO> GetByIdAsync(Guid id)
    {
        var categoryEntity = await _categoryRepository.GetByIdAsync(id);
        return _mapper.Map<CategoryResponseDTO>(categoryEntity);
    }

    public async Task<CategoryResponseDTO> CreateAsync(CategoryCreateDTO category)
    {
        var categoryEntity = new Category(category.Name);
        await _categoryRepository.CreateAsync(categoryEntity);
        return _mapper.Map<CategoryResponseDTO>(categoryEntity);
    }

    public async Task<ServicesResult<CategoryResponseDTO>> UpdateAsync(Guid id, CategoryUpdateDTO category)
    {
        var result = new ServicesResult<CategoryResponseDTO>();
        var categoryEntity = await _categoryRepository.GetByIdAsync(id);

        if (categoryEntity is null)
        {
            result.AddErrors("Categoria", "Categoria não encontrada");
            return result;
        }

        categoryEntity.Update(category.Name);

        return result.WithData(_mapper.Map<CategoryResponseDTO>(categoryEntity));
    }

    public async Task<ServicesResult<CategoryResponseDTO>> DeleteAsync(Guid id)
    {
        var result = new ServicesResult<CategoryResponseDTO>();
        var categoryEntity = await _categoryRepository.GetByIdAsync(id);

        if (categoryEntity is null)
        {
            result.AddErrors("Categoria", "Categoria não encontrada");
            return result;
        }

        return result.WithData(_mapper.Map<CategoryResponseDTO>(categoryEntity));
    }
}
