using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VasuAPI.Services;

namespace VasuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CsvDataController : ControllerBase
    {
        private readonly CsvDataService _csvDataService;

        public CsvDataController(CsvDataService csvDataService)
        {
            _csvDataService = csvDataService;
        }

        [HttpGet]
        [Route("GetCsvData", Name = "GetCsvData")]
        public ActionResult<List<User>> GetData(int count)
        {
            return _csvDataService.GetData(count);
        }
    }
}



