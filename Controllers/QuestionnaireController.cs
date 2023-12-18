using Microsoft.AspNetCore.Mvc;
using WPR.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WPR
{
    [Route("api/questionnaire")]
    [ApiController]
    public class QuestionnaireController : ControllerBase
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;

        public QuestionnaireController(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        // GET: api/questionnaire
        [HttpGet]
        public async Task<List<Questionnaire>> Get()
        {
            List<Questionnaire> questionnaires = await _questionnaireRepository.Get();
            return questionnaires;
        }

        // GET api/questionnaire/3
        [HttpGet("{id}")]
        public async Task<Questionnaire> Get(int id)
        {
            Questionnaire questionnaire = await _questionnaireRepository.GetById(id);
            return questionnaire;
        }

        // POST api/questionnaire
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

        // PUT api/questionnaire/3
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] Questionnaire questionnaire)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _questionnaireRepository.Update(questionnaire);

            return Ok();
        }
    }
}
