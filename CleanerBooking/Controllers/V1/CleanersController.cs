using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace CleanerBooking.Controllers.V1;

[Route("api/cleaner")]
[ApiController]
public class CleanersController: ControllerBase
{
    private readonly ICleanerRepository _cleanerRepository;

    public CleanersController(ICleanerRepository cleanerRepository)
    {
        _cleanerRepository = cleanerRepository;
    }

    [HttpGet]
    public ActionResult<List<Cleaner>> Get()
    {
        return Ok(_cleanerRepository.GetCleaners());
    }
}