using Microsoft.AspNetCore.Mvc;

namespace iFHMS.DotnetCodingChallenge.Controllers;

[ApiController]
[Route("[controller]")]
public class Default : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Default Controller");
    }
}