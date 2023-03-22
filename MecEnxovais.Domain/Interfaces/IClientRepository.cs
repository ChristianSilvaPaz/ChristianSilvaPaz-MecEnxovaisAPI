using MecEnxovais.Domain.Entities;

namespace MecEnxovais.Domain.Interfaces;
public interface IClientRepository
{
    Task<IEnumerable<Client>> GetAsync();
    Task<Client> GetByIdAsync(Guid id);
    Task<Client> CreateAsync(Client client);
    Task<Client> UpdateAsync(Client client);
    Task DeleteAsync(Client client);
}
