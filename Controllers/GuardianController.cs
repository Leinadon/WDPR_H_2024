using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    [Route("api/guardians")]
    [ApiController]
    public class GuardianController : ControllerBase
    {
        private readonly IGuardianService _guardianService;
        private readonly IUserService _userService;
        private readonly ILogger<GuardianController> _logger;        

        public GuardianController(IGuardianService guardianService, IUserService userService, ILogger<GuardianController> logger)
        {
            _guardianService = guardianService;
            _userService = userService;
            _logger = logger;            
        }

        // GET: api/guardians
        [HttpGet]
        public async Task<ActionResult<List<Guardian>>> Get()
        {
            try
            {
                List<Guardian> guardians = await _guardianService.Get();
                return Ok(guardians);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van guardians, GET: api/Guardians");
                return Problem("Probleem bij het opvragen van alle instanties van een Guardian object"); //Loggen
            }
        }

        // GET: api/guardians/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                Guardian? guardian = await _guardianService.GetById(id);
                if (guardian == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(guardian);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van chats, GET: api/chats");
                return Problem("Probleem bij het opvragen van een Guardian object"); //Dit moeten we loggen  
            }
        }

        // POST: api/guardians
        [HttpPost]
        public async Task<ActionResult<Guardian>> Create([FromBody] Guardian guardian)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return CreatedAtRoute("Get", new { id = guardian.Id }, await _guardianService.Create(guardian));

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van chats, GET: api/chats");
                return Problem("Probleem bij het posten van een Guardian object"); //loggen
            }
        }

        // PUT: api/guardians/id/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Guardian guardian)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                Guardian? oldGuardian = await _guardianService.GetById(id);
                if (oldGuardian == null)
                {
                    return NotFound(); // Return 404 if the guardian is not found
                }
                await _guardianService.Update(id, guardian);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van chats, GET: api/chats");
                return Problem("Probleem bij het updaten van een Guardian object"); //loggen
            }
        }

        // DELETE: api/guardians/id/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Guardian? guardian = await _guardianService.GetById(id);
                if (guardian == null)
                {
                    return NotFound(); // Return 404
                }

                await _guardianService.Delete(id);
                return NoContent(); // Return 204
            }
            catch
            {
                return Problem("Probleem bij het deleten van een Guardian object");
            }
        }
    }
}