using Microsoft.AspNetCore.Mvc;

namespace Microservice.Membership.Controllers;

[ApiController]
[Route("membership")]
public class MembershipController : ControllerBase
{
    private readonly ILogger<MembershipController> logger;

    public MembershipController(ILogger<MembershipController> logger)
    {
        this.logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
