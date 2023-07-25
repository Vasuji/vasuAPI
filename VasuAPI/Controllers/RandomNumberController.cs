using Microsoft.AspNetCore.Mvc;
using VasuAPI.Services;
using VasuAPI.Models;

namespace VasuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumberController : ControllerBase
    {
        private readonly ILogger<RandomNumberController> _logger;
        private readonly IRandomNumberService _randomNumberService;

        public RandomNumberController(ILogger<RandomNumberController> logger, IRandomNumberService randomNumberService)
        {
            _logger = logger;
            _randomNumberService = randomNumberService;
        }

        [HttpGet]
        public RandomNumberModel Get()
        {
            var number = _randomNumberService.GenerateRandomNumber(1, 100);
            return new RandomNumberModel { Number = number };
        }
    }
}
