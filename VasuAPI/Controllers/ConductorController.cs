using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VasuAPI.Services;

namespace VasuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConductorController : ControllerBase
    {
        private readonly IConductorService _conductorService;

        public ConductorController(IConductorService conductorService)
        {
            _conductorService = conductorService;
        }

        [HttpGet("start")]
        public async Task<ActionResult> StartWorkflow()
        {
            var workflowName = "test"; // replace with your workflow name
            var result = await _conductorService.StartWorkflowAsync(workflowName);
            return Ok(result);
        }
    }

}