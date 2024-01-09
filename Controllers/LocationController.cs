using System.Drawing;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace WPR
{
    [Route("api/locations")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationRepository _locationRepository;
        public LocationController(ILocationRepository locationRepository){
            _locationRepository = locationRepository;
        }
        // GET: api/locations
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try{
                List<Location> locations = await _locationRepository.Get();
                return Ok(locations);
            }catch (Exception ex){
                return Problem("Probleem bij het opvragen van alle objecten"); //Loggen
            }
        }
        //GET: api/locations/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> Get(int id)
        {
            try{
                Location? location = await _locationRepository.GetByID(id);
                if(location == null){
                    return NotFound(); //Return 404 
                }
                return Ok(location);
            }catch(Exception ex){
                return Problem("Probleem bij het opvragen van een object"); //Dit moeten we loggen  
            }
        }
        // POST api/locations
        [HttpPost]
        public async Task<ActionResult<Location>> Create([FromBody] Location location)
        {  
            try{
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var createdLocation = await _locationRepository.Create(location);
                return CreatedAtAction(nameof(Get), new {id = createdLocation.Id}, createdLocation);

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
                Location? oldLocation = await _locationRepository.GetByID(id);
                if(oldLocation == null){
                    return NotFound(); //return 404 als de locatie niet gevonden is
                }
                await _locationRepository.Update(id, location);
                return NoContent(); //return 204
            }catch(Exception ex){
                return Problem("Probleem bij het updates van een object"); //loggen
            }
        }
        // DELETE: api/locations/id/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try{
                Location? location = await _locationRepository.GetByID(id);
                if(location == null){
                    return NotFound(); //return 404
                }

                await _locationRepository.Delete(id);
                return NoContent(); //return 204
            }catch
            {
                return Problem("Probleem bij het deleten van een object");
            }
        }

    }
}