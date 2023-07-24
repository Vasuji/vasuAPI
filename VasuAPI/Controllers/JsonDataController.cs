using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VasuAPI.Services;


namespace VasuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JsonDataController : ControllerBase
    {
        private readonly IJsonDataService _service;

        public JsonDataController(IJsonDataService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetJsonData", Name = "GetJsonData")]
        public IActionResult Get()
        {
            var users = _service.Users;
            return Ok(users);
        }
    }

}

