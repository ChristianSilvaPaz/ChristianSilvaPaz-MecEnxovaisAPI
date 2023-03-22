using AutoMapper;
using MecEnxovais.Application.DTOs.User;
using MecEnxovais.Application.Interfaces;
using MecEnxovais.Domain.Entities;
using MecEnxovais.Domain.Interfaces;

namespace MecEnxovais.Application.Services;
public class UserServices : IUserServices
{
    private readonly IUserRepository _userRepository;
    private readonly IAuthServices _authServices;
    private readonly IMapper _mapper;

    public UserServices(IUserRepository userRepository, IMapper mapper, IAuthServices authServices)
    {
        _userRepository = userRepository;
        _authServices = authServices;
        _mapper = mapper;
    }

    public Task<IEnumerable<UserResponseDTO>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserResponseDTO> GetByIdClientAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<UserResponseDTO> CreateAsync(UserCreateDTO user)
    {
        var passwordHash = _authServices.ComputeSha256Hash(user.Password);
        var userEntity = new User(user.FirstName, user.LastName, user.FullName, user.Email, passwordHash, user.CompanyId);
        
        await _userRepository.CreateAsync(userEntity);

        return _mapper.Map<UserResponseDTO>(userEntity);
    }

    public Task<UserResponseDTO> UpdateAsync(UserUpdateDTO user)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponseDTO> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
