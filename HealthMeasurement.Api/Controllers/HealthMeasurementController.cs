using HealthMeasurement.Application.Health;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HealthMeasurement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthMeasurementController : ControllerBase
    {
        private readonly IHealthMeasurementService _healthMeasurementService;
        public HealthMeasurementController(IHealthMeasurementService healthMeasurementService)
        {
            _healthMeasurementService = healthMeasurementService;
        }
        [HttpPost("getMonitor")]
        [Authorize]
        public async Task<IActionResult> GetDataMonitor()
        {
            var result = await _healthMeasurementService.GetDataMonitor();
            if (result ==null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
