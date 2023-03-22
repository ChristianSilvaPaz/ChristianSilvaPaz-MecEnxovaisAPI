using MecEnxovais.Domain.Entities;

namespace MecEnxovais.Domain.Interfaces;
public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAsync();
    Task<Category> GetByIdAsync(Guid id);
    Task<Category> CreateAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    Task DeleteAsync(Category category);
}
