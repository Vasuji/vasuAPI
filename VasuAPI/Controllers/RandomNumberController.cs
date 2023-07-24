using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VasuAPI.Services;
using VasuAPI.Models;

namespace VasuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumberController : ControllerBase
    {
        private readonly ILogger<RandomNumberController> _logger;

        public RandomNumberController(ILogger<RandomNumberController> logger)
        {
            _logger = logger;
        }

        //This is the main API call
        [HttpGet]
        [Route("GetRandomNumbers", Name = "GetRandomNumbers")]
        public IEnumerable<RandomNumber> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new RandomNumber
            {
                Date = DateTime.Now.AddDays(index),
                Number = Random.Shared.Next(-1000, 1000), // Generates random numbers between -1000 and 1000
            })
            .ToArray();
        }
    }
}
