using HealthMeasurement.Application.System.Roles;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HealthMeasurement.Api.Controllers
{

    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _roleService.GetAll();
            return Ok(roles);
        }
    }
}