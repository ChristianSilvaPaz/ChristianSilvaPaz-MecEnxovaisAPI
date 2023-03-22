using MecEnxovais.Application.DTOs.Login;
using MecEnxovais.Application.Result;

namespace MecEnxovais.Application.Interfaces;
public interface ILoginServices
{
    Task<ServicesResult<LoginResponseDTO>> Login(LoginCreateDTO login);
}
