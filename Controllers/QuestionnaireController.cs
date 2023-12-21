using Microsoft.AspNetCore.Mvc;
using WPR.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WPR
{
    [Route("api/questionnaires")]
    [ApiController]
    public class QuestionnaireController : ControllerBase
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;

        public QuestionnaireController(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        // GET: api/questionnaires
        [HttpGet]
        public async Task<List<Questionnaire>> Get()
        {
            List<Questionnaire> questionnaires = await _questionnaireRepository.Get();
            return questionnaires;
        }

        // GET api/questionnaires/3
        [HttpGet("{id}")]
        public async Task<Questionnaire?> Get(int id)
        {
            Questionnaire? questionnaire = await _questionnaireRepository.GetById(id);
            return questionnaire;
        }

        // POST api/questionnaires
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Questionnaire questionnaire)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _questionnaireRepository.Create(questionnaire);

            return Ok();
        }

        // PUT api/questionnaires/3
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Questionnaire questionnaire)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _questionnaireRepository.Update(id, questionnaire);

            return Ok();
        }

        // DELETE api/questionnaires/3
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _questionnaireRepository.Delete(id);

                return Ok();
            }
            catch (Exception e)
            {
                return Ok();
            }
        }
    }
}
