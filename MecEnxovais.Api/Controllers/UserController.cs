using MecEnxovais.Application.DTOs.User;
using MecEnxovais.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MecEnxovais.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;   
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] UserCreateDTO userCreateDTO)
        {
            var user = await _userServices.CreateAsync(userCreateDTO);

            return Ok(user);
        }
    }
}
