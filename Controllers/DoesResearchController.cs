using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    [Route("api/doesresearch")]
    [ApiController]
    public class DoesResearchController : ControllerBase
    {
        private readonly IDoesResearchService _doesResearchService;
        private readonly IUserService _userService;
        private readonly ILogger<DoesResearchController> _logger;

        public DoesResearchController(IDoesResearchService doesResearchService, IUserService userService, ILogger<DoesResearchController> logger)
        {
            _doesResearchService = doesResearchService;
            _userService = userService;
            _logger = logger;            
        }

        // GET: api/doesresearch
        [HttpGet]
        public async Task<ActionResult<List<DoesResearch>>> Get()
        {
            try
            {
                List<DoesResearch> doesResearchList = await _doesResearchService.Get();
                return Ok(doesResearchList);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van does_reasearch, GET: api/chats");
                return Problem("Problem retrieving all instances of a DoesResearch object"); // Logging
            }
        }

        // GET: api/doesresearch/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                DoesResearch? doesResearch = await _doesResearchService.GetById(id);
                if (doesResearch == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(doesResearch);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van does_reasearch, GET: api/chats");
                return Problem("Problem retrieving a DoesResearch object"); // Logging  
            }
        }

        // POST: api/doesresearch
        [HttpPost]
        public async Task<ActionResult<DoesResearch>> Create([FromBody] DoesResearch doesResearch)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return CreatedAtRoute("Get", new { id = doesResearch.ID }, await _doesResearchService.Create(doesResearch));

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van does_reasearch, GET: api/chats");
                return Problem("Problem posting a DoesResearch object"); // Logging
            }
        }

        // PUT: api/doesresearch/id/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] DoesResearch doesResearch)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                DoesResearch? oldDoesResearch = await _doesResearchService.GetById(id);
                if (oldDoesResearch == null)
                {
                    return NotFound(); // Return 404 if the DoesResearch is not found
                }
                await _doesResearchService.Update(id, doesResearch);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van does_reasearch, GET: api/chats");
                return Problem("Problem updating a DoesResearch object"); // Logging
            }
        }

        // DELETE: api/doesresearch/id/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                DoesResearch? doesResearch = await _doesResearchService.GetById(id);
                if (doesResearch == null)
                {
                    return NotFound(); // Return 404
                }

                await _doesResearchService.Delete(id);
                return NoContent(); // Return 204
            }
            catch
            {
                return Problem("Problem deleting a DoesResearch object");
            }
        }
    }
}
