using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    [Route("api/questions")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        private readonly IUserService _userService;
        private readonly ILogger<QuestionController> _logger;

        public QuestionController(IQuestionService questionService, IUserService userService, ILogger<QuestionController> logger)
        {
            _questionService = questionService;
            _userService = userService;
            _logger = logger;
        }

        // GET: api/questions
        [HttpGet]
        public async Task<ActionResult<List<Question>>> Get()
        {
            try
            {
                List<Question> questions = await _questionService.Get();
                return Ok(questions);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van action_results, GET: api/chats");                
                return Problem("Problem retrieving all instances of a Question object"); // Logging
            }
        }

        // GET: api/questions/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                Question? question = await _questionService.GetById(id);
                if (question == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(question);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van action_results, GET: api/chats");
                return Problem("Problem retrieving a Question object"); // Logging  
            }
        }

        // POST: api/questions
        [HttpPost]
        public async Task<ActionResult<Question>> Create([FromBody] Question question)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return CreatedAtRoute("Get", new { id = question.ID }, await _questionService.Create(question));

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van action_results, GET: api/chats");
                return Problem("Problem posting a Question object"); // Logging
            }
        }

        // PUT: api/questions/id/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Question question)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                Question? oldQuestion = await _questionService.GetById(id);
                if (oldQuestion == null)
                {
                    return NotFound(); // Return 404 if the question is not found
                }
                await _questionService.Update(id, question);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van action_results, GET: api/chats");
                return Problem("Problem updating a Question object"); // Logging
            }
        }

        // DELETE: api/questions/id/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Question? question = await _questionService.GetById(id);
                if (question == null)
                {
                    return NotFound(); // Return 404
                }

                await _questionService.Delete(id);
                return NoContent(); // Return 204
            }
            catch
            {
                return Problem("Problem deleting a Question object");
            }
        }
    }
}
