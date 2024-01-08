using System.IO.Pipelines;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

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

        public async Task Delete(int id)
        {

        }
    }
}

