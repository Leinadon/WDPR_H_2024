using System.Drawing;
using System.Formats.Asn1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph.Models;

namespace WPR
{
    [Route("api/answers")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _answerService;
        private readonly ILogger<AnswerController> _logger;

        public AnswerController(IAnswerService answerService, ILogger<AnswerController> logger)
        {
            _answerService = answerService;
            _logger = logger;
        }

        // GET: api/answers
        [HttpGet]
        public async Task<ActionResult<List<Answer>>> Get()
        {
            try{
                List<Answer> answers = await _answerService.Get();
                if(answers != null){
                    return Ok(answers);
                }
                return NoContent();
            }catch(Exception ex){
                _logger.LogError(ex, "Fout opgetreden in answers Get() api/answers");
                return Problem("Probleem bij het opvragen van alle instantie van een object");
            }
        }
        // GET: api/answers/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try{
                Answer? answer = await _answerService.GetById(id);
                if(answer == null){
                    return NotFound();
                }
                return Ok(answer);
            }catch(Exception ex){
                _logger.LogError(ex, "An error occurred in Get(id) api/answers");            
                return Problem("Probleem bij het opvrgagen van een object");
            }
        }
        // POST api/answers
        [HttpPost]
        public async Task<ActionResult<Answer>> Create([FromBody] Answer answer)
        {
            try{
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return CreatedAtRoute("Get", new {id = answer.ID}, await _answerService.Create(answer));
            }catch(Exception ex){
                _logger.LogError(ex, "An error occurred in Create() api/answers");
                return Problem("Probleem bij het aanmaken van een object");
            }
        }
        // PUT: api/answers/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Answer answer)
        {
            try{
                if(!ModelState.IsValid){
                    return BadRequest(ModelState);
                }
                Answer? oldAnswer = await _answerService.GetById(id);
                if(oldAnswer == null){
                    return NotFound();
                }
                await _answerService.Update(id, answer);
                return NoContent();
            }catch(Exception ex){
                _logger.LogError(ex, "An error occurred in Update() api/answers");
                return Problem("Probleem bij het updaten van een object");
            }
        }
        // DETELE: api/answers/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try{
                Answer? answer = await _answerService.GetById(id);
                if(answer == null){
                    return NotFound();
                }
                await _answerService.Delete(id);
                return NoContent();
            }catch(Exception ex){
                _logger.LogError(ex, "An error occurred in Delete() api/answers");
                return Problem("Probleem bij het detelen van een object");
            }
        }
    }
}