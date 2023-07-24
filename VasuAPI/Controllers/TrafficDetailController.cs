using Microsoft.AspNetCore.Mvc;

namespace VasuAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TrafficDetailController : ControllerBase
{


    private readonly ILogger<TrafficDetailController> _logger;

    public TrafficDetailController(ILogger<TrafficDetailController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    [Route("GetTrafficDetail", Name = "GetTrafficDetail")]
    public ActionResult<TrafficDetail> GetTrafficDetail()
    {
        return new TrafficDetail
        {
            Time = DateTime.Now,
            Source = "SourceCity",
            Destination = "DestinationCity",
            Volume = new Random().Next(1000, 5000)
        };
    }

}
