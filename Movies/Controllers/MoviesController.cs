using Microsoft.AspNetCore.Mvc;

namespace Microservice.Movies.Controllers;

[ApiController]
[Route("movies")]
public class MoviesController : ControllerBase
{
    private readonly ILogger<MoviesController> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="MoviesController"/> class.
    /// </summary>
    /// <param name="logger"></param>
    public MoviesController(ILogger<MoviesController> logger)
    {
        this.logger = logger;
    }

    [HttpGet]
    public IActionResult GetMovie()
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult GetMovies()
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult CreateMovie()
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult UpdateMovie()
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeleteMovie()
    {
        return Ok();
    }
}