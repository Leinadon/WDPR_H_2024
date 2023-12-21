using Microsoft.AspNetCore.Mvc;
using WPR.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WPR
{
    [Route("api/companies")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        // GET: api/companies
        [HttpGet]
        public async Task<List<Company>> Get()
        {
            List<Company> companies = await _companyRepository.Get();
            return companies;
        }

        // GET api/companies/3
        [HttpGet("{id}")]
        public async Task<Company> Get(int id)
        {
            Company company = await _companyRepository.GetById(id);
            return company;
        }

        // POST api/companies/3
        [HttpPost("{id}")]
        public async Task<IActionResult> Create([FromBody] Company company)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Company createdCompany = await _companyRepository.Create(company);

            return Ok(createdCompany.CompanyId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Company company)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _companyRepository.Update(id, company);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _companyRepository.Delete(id);

            return Ok();
        }
    }
}
