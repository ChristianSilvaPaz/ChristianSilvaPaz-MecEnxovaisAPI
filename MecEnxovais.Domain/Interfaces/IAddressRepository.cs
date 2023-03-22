using MecEnxovais.Domain.Entities;

namespace MecEnxovais.Domain.Interfaces;
public interface IAddressRepository
{
    Task<IEnumerable<Address>> GetAsync();
    Task<Address> GetByIdClientAsync(Guid id);
    Task<Address> CreateAsync(Address address);
    Task<Address> UpdateAsync(Address address);
    Task DeleteAsync(Address address);
}
