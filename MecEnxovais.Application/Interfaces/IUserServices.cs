using MecEnxovais.Application.DTOs.User;
using MecEnxovais.Domain.Entities;

namespace MecEnxovais.Application.Interfaces;
public interface IUserServices
{
    Task<IEnumerable<UserResponseDTO>> GetAsync();
    Task<UserResponseDTO> GetByIdClientAsync(Guid id);
    Task<UserResponseDTO> CreateAsync(UserCreateDTO user);
    Task<UserResponseDTO> UpdateAsync(UserUpdateDTO user);
    Task<UserResponseDTO> DeleteAsync(Guid id);
}
