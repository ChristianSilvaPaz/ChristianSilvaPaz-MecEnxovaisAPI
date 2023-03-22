using MecEnxovais.Application.DTOs.Client;
using MecEnxovais.Application.Result;

namespace MecEnxovais.Application.Interfaces;
public interface IClientServices
{
    Task<IEnumerable<ClientResponseDTO>> GetAsync();
    Task<ClientResponseDTO> GetByIdAsync(Guid id);
    Task<ClientResponseDTO> CreateAsync(ClientCreateDTO client);
    Task<ServicesResult<ClientResponseDTO>> UpdateAsync(Guid id, ClientUpdateDTO client);
    Task<ServicesResult<ClientResponseDTO>> DeleteAsync(Guid id);
}
