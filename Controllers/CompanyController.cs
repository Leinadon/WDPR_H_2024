using Microsoft.AspNetCore.Mvc;

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

        // GET api/companies/5
        [HttpGet("{id}")]
        public async Task<Company> Get(int id)
        {
            Company company = await _companyRepository.GetById(id);
            return company;
        }


    }
}
