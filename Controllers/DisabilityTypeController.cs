using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    [Route("api/disabilitytypes")]
    [ApiController]
    public class DisabilityTypeController : ControllerBase
    {
        private readonly IDisabilityTypeService _disabilityTypeService;
        private readonly IUserService _userService;
        private readonly ILogger<DisabilityController> _logger;        

        public DisabilityTypeController(IDisabilityTypeService disabilityTypeService, IUserService userService, ILogger<DisabilityController> logger)
        {
            _disabilityTypeService = disabilityTypeService;
            _userService = userService;
            _logger = logger;
        }

        // GET: api/disabilitytypes
        [HttpGet]
        public async Task<ActionResult<List<DisabilityType>>> Get()
        {
            try
            {
                List<DisabilityType> disabilityTypes = await _disabilityTypeService.Get();
                return Ok(disabilityTypes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van disabillities_types, GET: api/chats");                
                return Problem("Problem retrieving all instances of a DisabilityType object"); // Logging
            }
        }

        // GET: api/disabilitytypes/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                DisabilityType? disabilityType = await _disabilityTypeService.GetById(id);
                if (disabilityType == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(disabilityType);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van disabillities_types, GET: api/chats");   
                return Problem("Problem retrieving a DisabilityType object"); // Logging  
            }
        }

        // POST: api/disabilitytypes
        [HttpPost]
        public async Task<ActionResult<DisabilityType>> Create([FromBody] DisabilityType disabilityType)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return CreatedAtRoute("Get", new { id = disabilityType.ID }, await _disabilityTypeService.Create(disabilityType));

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van disabillities_types, GET: api/chats");   
                return Problem("Problem posting a DisabilityType object"); // Logging
            }
        }

        // PUT: api/disabilitytypes/id/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] DisabilityType disabilityType)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                DisabilityType? oldDisabilityType = await _disabilityTypeService.GetById(id);
                if (oldDisabilityType == null)
                {
                    return NotFound(); // Return 404 if the disabilityType is not found
                }
                await _disabilityTypeService.Update(id, disabilityType);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van disabillities_types, GET: api/chats");   
                return Problem("Problem updating a DisabilityType object"); // Logging
            }
        }

        // DELETE: api/disabilitytypes/id/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                DisabilityType? disabilityType = await _disabilityTypeService.GetById(id);
                if (disabilityType == null)
                {
                    return NotFound(); // Return 404
                }

                await _disabilityTypeService.Delete(id);
                return NoContent(); // Return 204
            }
            catch
            {
                return Problem("Problem deleting a DisabilityType object");
            }
        }
    }
}
