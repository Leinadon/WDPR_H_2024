using System.Drawing;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using SQLitePCL;

namespace WPR
{
    [Route("api/locations")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        public LocationController(ILocationService locationService){
            _locationService = locationService;
        }
        // GET: api/locations
        [HttpGet]
        public async Task<ActionResult<List<Location>>> Get()
        {
            try{
                List<Location> locations = await _locationService.Get();
                return Ok(locations);
            }catch (Exception ex){
                return Problem("Probleem bij het opvragen van alle intanties van een object"); //Loggen
            }
        }
        //GET: api/locations/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try{
                Location? location = await _locationService.GetById(id);
                if(location == null){
                    return NotFound(); //Return 404 
                }
                return Ok(location);
            }catch(Exception ex){
                return Problem("Probleem bij het opvragen van een object"); //Dit moeten we loggen  
            }
        }
        // POST: api/locations
        [HttpPost]
        public async Task<ActionResult<Location>> Create([FromBody] Location location)
        {  
            try{
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return CreatedAtRoute("Get", new {id = location.Id}, await _locationService.Create(location));

            }catch(Exception ex){
                return Problem("Probleem bij het posten van een object"); //loggen
            }
        }
        // PUT: api/locations/id/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult>  Update(int id, [FromBody] Location location){
            try{
                if(!ModelState.IsValid){
                    return BadRequest(ModelState);
                }
                Location? oldLocation = await _locationService.GetById(id);
                if(oldLocation == null){
                    return NotFound(); //return 404 als de locatie niet gevonden is
                }
                await _locationService.Update(id, location);
                return NoContent(); //return 204
            }catch(Exception ex){
                return Problem("Probleem bij het updaten van een object"); //loggen
            }
        }
        // DELETE: api/locations/id/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try{
                Location? location = await _locationService.GetById(id);
                if(location == null){
                    return NotFound(); //return 404
                }

                await _locationService.Delete(id);
                return NoContent(); //return 204
            }catch
            {
                return Problem("Probleem bij het deleten van een object");
            }
        }

    }
}