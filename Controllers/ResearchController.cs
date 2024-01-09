using Microsoft.AspNetCore.Mvc;

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

        // GET: api/research
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try {
                List<Research> researches = await _researchService.Get();
                return Ok(researches);
            } catch {
                return Problem();
            }
        }

        // GET: api/research/3
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try {
                Research? research = await _researchService.GetById(id);
                
                if (research == null) {
                    return NotFound();
                }

                return Ok(research);
            } catch {
                return Problem();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try {
                await _researchService.Delete(id);

                return Ok();
            } catch {
                return Problem();
            }
        }

        [Route("questionnaire")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Questionnaire questionnaire)
        {
            try {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _researchService.Create(questionnaire);

                return Ok(questionnaire.ResearchId);
            } catch {
                return Problem();
            }
        }

        [HttpPut("questionnaire/{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] Questionnaire questionnaire)
        {
            try {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _researchService.Update(id, questionnaire);

                return Ok();
            } catch {
                return Problem();
            }
        }

        [Route("interview")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Interview interview)
        {
            try {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _researchService.Create(interview);

                return Ok(interview.ResearchId);
            } catch {
                return Problem();
            }
        }

        [HttpPut("interview/{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] Interview interview)
        {
            try {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                
                await _researchService.Update(id, interview);

                return Ok();
            } catch {
                return Problem();
            }
        }
        
        [Route("online-assignment")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OnlineAssignment onlineAssignment)
        {
            try {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await _researchService.Create(onlineAssignment);

                return Ok(onlineAssignment.ResearchId);
            } catch {
                return Problem();
            }
        }

        [HttpPut("online-assignment/{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] OnlineAssignment onlineAssignment)
        {
            try {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                
                await _researchService.Update(id, onlineAssignment);

                return Ok();
            } catch {
                return Problem();
            }
        }
    }
}

