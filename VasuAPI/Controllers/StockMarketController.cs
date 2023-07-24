using Microsoft.AspNetCore.Mvc;
using VasuAPI.Services;

namespace VasuAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class StockMarketController : ControllerBase
{


    private readonly ILogger<StockMarketController> _logger;

    public StockMarketController(ILogger<StockMarketController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    [Route("GetStockStatus", Name = "GetStockStatus")]
    public ActionResult<StockStatus> GetStockStatus(string stockName)
    {
        // In a real-world application, you would call a service here to get real-time stock data
        // For this example, we will just return a static status

        return new StockStatus
        {
            StockName = stockName,
            StockPrice = new Random().Next(100, 5000),
            StockChange = new Random().Next(0, 2) == 0 ? "Up" : "Down"
        };
    }

}
