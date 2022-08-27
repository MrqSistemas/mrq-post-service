using Microsoft.AspNetCore.Mvc;
using YourProjectName.Application.Applications;
using YourProjectName.Domain.Adapters.Dtos;

namespace YourProjectName.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserApplication _userApplication;

        public UserController(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userApplication.GetList();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        { 
            return Ok(_userApplication.Get(id));
        }

        [HttpPost]
        public async Task <IActionResult> Post(UserDto user)
        {
            return Ok(await _userApplication.Add(user));
        }

        [HttpPut]
        public IActionResult Put(UserDto user)
        {
            return Ok(_userApplication.Update(user));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_userApplication.Delete(id));
        }
    }
}
