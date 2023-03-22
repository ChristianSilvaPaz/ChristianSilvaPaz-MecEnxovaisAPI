using MecEnxovais.Domain.Entities;

namespace MecEnxovais.Domain.Interfaces;
public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAsync();
    Task<Product> GetByIdAsync(Guid id);
    Task<Product> CreateAsync(Product product);
    Task<Product> UpdateAsync(Product product);
    Task DeleteAsync(Product product);
}
