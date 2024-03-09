using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Confluent.Kafka;


namespace CleanerBooking.Controllers.V1;

[Route("api/cleaner")]
[ApiController]
public class CleanersController: ControllerBase
{
    private readonly ICleanerRepository _cleanerRepository;
    private readonly ProducerConfig _config;
    private int _counter;

    public CleanersController(ICleanerRepository cleanerRepository)
    {
        _cleanerRepository = cleanerRepository;
        _config = new ProducerConfig
        {
            BootstrapServers = "localhost:29092"
        };
        _counter = 0;
    }

    [HttpGet]
    public async Task<ActionResult<List<Cleaner>>> Get()
    {
        var cleaners = _cleanerRepository.GetCleaners();
        using (var producer = new ProducerBuilder<Null, string>(_config).Build())
        {
            try
            {
                var result = await producer.ProduceAsync("important", new Message<Null, string> { Value="test message" });
                Console.WriteLine($"Message produced: {result.Message.Value}");
            }
            catch (ProduceException<Null, string> e)
            {
                Console.WriteLine($"Failed to produce message: {e.Error.Reason}");
            }
        }
        _counter++;
        return Ok(cleaners);
    }
}