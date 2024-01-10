using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    [Route("api/onlineassignmentresults")]
    [ApiController]
    public class OnlineAssignmentResultController : ControllerBase
    {
        private readonly IOnlineAssignmentResultService _onlineAssignmentResultService;

        public OnlineAssignmentResultController(IOnlineAssignmentResultService onlineAssignmentResultService)
        {
            _onlineAssignmentResultService = onlineAssignmentResultService;
        }

        // GET: api/onlineassignmentresults
        [HttpGet]
        public async Task<ActionResult<List<OnlineAssignmentResult>>> Get()
        {
            try
            {
                List<OnlineAssignmentResult> results = await _onlineAssignmentResultService.Get();
                return Ok(results);
            }
            catch (Exception ex)
            {
                return Problem("Problem retrieving all instances of an OnlineAssignmentResult object"); // Logging
            }
        }

        // GET: api/onlineassignmentresults/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                OnlineAssignmentResult? result = await _onlineAssignmentResultService.GetById(id);
                if (result == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem("Problem retrieving an OnlineAssignmentResult object"); // Logging  
            }
        }

        // POST: api/onlineassignmentresults
        [HttpPost]
        public async Task<ActionResult<OnlineAssignmentResult>> Create([FromBody] OnlineAssignmentResult result)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return CreatedAtRoute("Get", new { id = result.ID }, await _onlineAssignmentResultService.Create(result));

            }
            catch (Exception ex)
            {
                return Problem("Problem posting an OnlineAssignmentResult object"); // Logging
            }
        }

        // PUT: api/onlineassignmentresults/id/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] OnlineAssignmentResult result)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                OnlineAssignmentResult? oldResult = await _onlineAssignmentResultService.GetById(id);
                if (oldResult == null)
                {
                    return NotFound(); // Return 404 if the result is not found
                }
                await _onlineAssignmentResultService.Update(id, result);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Problem updating an OnlineAssignmentResult object"); // Logging
            }
        }

        // DELETE: api/onlineassignmentresults/id/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                OnlineAssignmentResult? result = await _onlineAssignmentResultService.GetById(id);
                if (result == null)
                {
                    return NotFound(); // Return 404
                }

                await _onlineAssignmentResultService.Delete(id);
                return NoContent(); // Return 204
            }
            catch
            {
                return Problem("Problem deleting an OnlineAssignmentResult object");
            }
        }
    }
}