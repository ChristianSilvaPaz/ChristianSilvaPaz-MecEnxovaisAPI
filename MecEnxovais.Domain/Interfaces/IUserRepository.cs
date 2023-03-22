using MecEnxovais.Domain.Entities;

namespace MecEnxovais.Domain.Interfaces;
public interface IUserRepository
{
    Task<IEnumerable<User>> GetAsync();
    Task<User> GetByIdAsync(Guid id);
    Task<User> GetByEmailAsync(string email);
    Task<User> CreateAsync(User user);
    Task<User> UpdateAsync(User user);
    Task DeleteAsync(User user);
}
