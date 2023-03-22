using MecEnxovais.Application.DTOs.Product;
using MecEnxovais.Application.Result;

namespace MecEnxovais.Application.Interfaces;
public interface IProductServices
{
    Task<IEnumerable<ProductResponseDTO>> GetAsync();
    Task<ProductResponseDTO> GetByIdAsync(Guid id);
    Task<ProductResponseDTO> CreateAsync(ProductCreateDTO product);
    Task<ServicesResult<ProductResponseDTO>> UpdateAsync(Guid id, ProductUpdateDTO product);
    Task<ServicesResult<ProductResponseDTO>> DeleteAsync(Guid id);
}
