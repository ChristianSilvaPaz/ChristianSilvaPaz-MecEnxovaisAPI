using MecEnxovais.Application.DTOs.Login;
using MecEnxovais.Application.Interfaces;
using MecEnxovais.Application.Result;
using MecEnxovais.Domain.Interfaces;

namespace MecEnxovais.Application.Services;
public class LoginServices : ILoginServices
{
    private readonly IUserRepository _userRepository;
    private readonly IAuthServices _authServices;

    public LoginServices(IUserRepository userRepository, IAuthServices authServices)
    {
        _userRepository = userRepository;
        _authServices = authServices;
    }

    public async Task<ServicesResult<LoginResponseDTO>> Login(LoginCreateDTO login)
    {
        var result = new ServicesResult<LoginResponseDTO>();
        var userEntity = await _userRepository.GetByEmailAsync(login.Email);

        if (userEntity == null)
        {
            result.AddErrors("Login", "Utilizador não encontado");
            return result;
        }

        var passwordHash = _authServices.ComputeSha256Hash(login.Password);

        if (!passwordHash.Equals(userEntity.Password))
        {
            result.AddErrors("Login", "Senha inválida");
            return result;
        }

        return result.WithData(new LoginResponseDTO { Token = _authServices.GenerateJwtToken(login.Email) });
    }
}
