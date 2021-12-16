using Microsoft.AspNetCore.Mvc;

namespace Microservice.Users.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> logger;

        public UsersController(ILogger<UsersController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}