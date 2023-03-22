using MecEnxovais.Application.DTOs.Login;
using MecEnxovais.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MecEnxovais.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    private readonly ILoginServices _loginServices;

    public LoginController(ILoginServices loginServices)
    {
        _loginServices = loginServices;
    }

    [HttpPost]
    public async Task<ActionResult<LoginResponseDTO>> Login([FromBody]LoginCreateDTO login)
    {
        var result = await _loginServices.Login(login);

        return !result.Errors.Any() ? Ok(result.Data) : BadRequest(result.Errors);
    }
}
