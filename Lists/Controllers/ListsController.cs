using Microsoft.AspNetCore.Mvc;

namespace Microservice.Lists.Controllers;

[ApiController]
[Route("lists")]
public class ListsController : ControllerBase
{
    private readonly ILogger<ListsController> logger;

    public ListsController(ILogger<ListsController> logger)
    {
        this.logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
