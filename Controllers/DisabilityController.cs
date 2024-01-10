using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    [Route("api/disabilities")]
    [ApiController]
    public class DisabilityController : ControllerBase
    {
        private readonly IDisabilityService _disabilityService;

        public DisabilityController(IDisabilityService disabilityService)
        {
            _disabilityService = disabilityService;
        }

        // GET: api/disabilities
        [HttpGet]
        public async Task<ActionResult<List<Disability>>> Get()
        {
            try
            {
                List<Disability> disabilities = await _disabilityService.Get();
                return Ok(disabilities);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van alle instanties van een Disability object"); // Loggen
            }
        }

        // GET: api/disabilities/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                Disability? disability = await _disabilityService.GetById(id);
                if (disability == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(disability);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van een Disability object"); // Dit moeten we loggen  
            }
        }

        // POST: api/disabilities
        [HttpPost]
        public async Task<ActionResult<Disability>> Create([FromBody] Disability disability)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return CreatedAtRoute("Get", new { id = disability.DisabilityId }, await _disabilityService.Create(disability));

            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het posten van een Disability object"); // Loggen
            }
        }

        // PUT: api/disabilities/id/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Disability disability)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                Disability? oldDisability = await _disabilityService.GetById(id);
                if (oldDisability == null)
                {
                    return NotFound(); // Return 404 if the disability is not found
                }
                await _disabilityService.Update(id, disability);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het updaten van een Disability object"); // Loggen
            }
        }

        // DELETE: api/disabilities/id/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Disability? disability = await _disabilityService.GetById(id);
                if (disability == null)
                {
                    return NotFound(); // Return 404
                }

                await _disabilityService.Delete(id);
                return NoContent(); // Return 204
            }
            catch
            {
                return Problem("Probleem bij het deleten van een Disability object");
            }
        }
    }
}
