using Microsoft.AspNetCore.Mvc;

namespace CleanerBooking.Controllers.V1;

[Route("api/health")]
[ApiController]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new object());
    }
}