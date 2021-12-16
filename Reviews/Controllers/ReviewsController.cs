using Microsoft.AspNetCore.Mvc;

namespace Microservice.Reviews.Controllers
{
    [ApiController]
    [Route("reviews")]
    public class ReviewsController : ControllerBase
    {
        private readonly ILogger<ReviewsController> logger;

        public ReviewsController(ILogger<ReviewsController> logger)
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