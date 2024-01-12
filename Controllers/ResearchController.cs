using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    [Route("api/research")]
    [ApiController]
    public class ResearchController : ControllerBase
    {
        private readonly IResearchService _researchService;

        public ResearchController(IResearchService researchService)
        {
            _researchService = researchService;
        }

        [HttpGet]
        public async Task<IActionResult> GetResearches()
        {
            try
            {
                List<Research> researches = await _researchService.GetResearches();
                return Ok(researches);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van alle onderzoeken");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Research>> GetResearchById(int id)
        {
            try
            {
                Research? research = await _researchService.GetById(id);
                if (research == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(research);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van een onderzoek");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResearch(int id)
        {
            try
            {
                await _researchService.DeleteResearch(id);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het verwijderen van een onderzoek");
            }
        }

        [HttpPost("questionnaire")]
        public async Task<ActionResult<Questionnaire>> CreateQuestionnaire([FromBody] Questionnaire questionnaire)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var createdQuestionnaire = await _researchService.CreateQuestionnaire(questionnaire);
                return CreatedAtAction(nameof(GetResearchById), new { id = createdQuestionnaire.ID }, createdQuestionnaire);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het toevoegen van een vragenlijst");
            }
        }

        [HttpGet("{id}/questionnaire")]
        public async Task<ActionResult<Questionnaire>> GetQuestionnaire(int id)
        {
            try
            {
                Questionnaire? questionnaire = await _researchService.GetQuestionnaireById(id);
                if (questionnaire == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(questionnaire);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van een vragenlijst");
            }
        }

        [HttpPut("{id}/questionnaire")]
        public async Task<IActionResult> UpdateQuestionnaire(int id, [FromBody] Questionnaire questionnaire)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _researchService.UpdateQuestionnaire(id, questionnaire);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het bijwerken van een vragenlijst");
            }
        }

        [HttpDelete("{id}/questionnaire")]
        public async Task<IActionResult> DeleteQuestionnaire(int id)
        {
            try
            {
                await _researchService.DeleteQuestionnaire(id);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het verwijderen van een vragenlijst");
            }
        }
        [HttpPost("onlineassignment")]
        public async Task<ActionResult<OnlineAssignment>> CreateOnlineAssignment([FromBody] OnlineAssignment onlineAssignment)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var createdOnlineAssignment = await _researchService.CreateOnlineAssignment(onlineAssignment);
                return CreatedAtAction(nameof(GetResearchById), new { id = createdOnlineAssignment.ID }, createdOnlineAssignment);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het toevoegen van een online opdracht");
            }
        }

        [HttpGet("{id}/onlineassignment")]
        public async Task<ActionResult<OnlineAssignment>> GetOnlineAssignment(int id)
        {
            try
            {
                OnlineAssignment? onlineAssignment = await _researchService.GetOnlineAssignmentById(id);
                if (onlineAssignment == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(onlineAssignment);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van een online opdracht");
            }
        }

        [HttpPut("{id}/onlineassignment")]
        public async Task<IActionResult> UpdateOnlineAssignment(int id, [FromBody] OnlineAssignment onlineAssignment)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _researchService.UpdateOnlineAssignment(id, onlineAssignment);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het bijwerken van een online opdracht");
            }
        }

        [HttpDelete("{id}/onlineassignment")]
        public async Task<IActionResult> DeleteOnlineAssignment(int id)
        {
            try
            {
                await _researchService.DeleteOnlineAssignment(id);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het verwijderen van een online opdracht");
            }
        }

        [HttpPost("interview")]
        public async Task<ActionResult<Interview>> CreateInterview([FromBody] Interview interview)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var createdInterview = await _researchService.CreateInterview(interview);
                return CreatedAtAction(nameof(GetResearchById), new { id = createdInterview.ID }, createdInterview);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het toevoegen van een interview");
            }
        }

        [HttpGet("{id}/interview")]
        public async Task<ActionResult<Interview>> GetInterview(int id)
        {
            try
            {
                Interview? interview = await _researchService.GetInterviewById(id);
                if (interview == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(interview);
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het opvragen van een interview");
            }
        }

        [HttpPut("{id}/interview")]
        public async Task<IActionResult> UpdateInterview(int id, [FromBody] Interview interview)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _researchService.UpdateInterview(id, interview);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het bijwerken van een interview");
            }
        }

        [HttpDelete("{id}/interview")]
        public async Task<IActionResult> DeleteInterview(int id)
        {
            try
            {
                await _researchService.DeleteInterview(id);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                return Problem("Probleem bij het verwijderen van een interview");
            }
        }
    }
}
