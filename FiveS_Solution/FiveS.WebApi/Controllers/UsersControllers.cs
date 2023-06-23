using FiveS.Entities.Dtos;
using FiveS.Entities.Entities;
using FiveS.Services.ServiceManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FiveS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UsersController(IServiceManager manager)
        {
            _serviceManager = manager;
        }

        [HttpGet]
        public IActionResult Get()
        {
            User user = new();
            user.Id = 1;
            user.Name = "Mert";
            user.Surname = "Durukan";
            user.Email = "abc@gmail.com";
            user.ControlAreaREF = 1;
            user.FacilityREF = 1;
            user.CompanyRegistrationNumber = "1";
            user.Password = "password";
            user.Role = 0;

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOneUserAsync(UserDto userDto)
        {
            await _serviceManager.User.CreateOneUserAsync(userDto);

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto userDto)
        {
            //check username, password
            var x = await _serviceManager.User.GetOneUserByUsernameAsync(userDto, false);
            return Ok("");
        }

        [HttpPost("forget-password")]
        public async Task<IActionResult> ForgetPassword()
        {
            return Ok("");
        }
    }
}
