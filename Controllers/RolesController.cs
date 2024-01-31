using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    [Route("api/roles")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRolesService _rolesService;
        private readonly IUserService _userService;
        private readonly ILogger<RolesController> _logger;

        public RolesController(IRolesService rolesService, IUserService userService, ILogger<RolesController> logger)
        {
            _rolesService = rolesService;
            _userService = userService;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Roles>> GetRoleById(int id)
        {
            try
            {
                Roles? role = await _rolesService.GetById(id);
                if (role == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(role);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van roles_controller, GET: api/roles/id");
                return Problem("Probleem bij het opvragen van een rol");
            }
        }
    }
}
