using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    [Route("api/companies")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        private readonly IUserService _userService;

        private readonly ILogger<CompanyController> _logger;

        public CompanyController(ICompanyService companyService, IUserService userService, ILogger<CompanyController> logger)
        {
            _companyService = companyService;
            _userService = userService;
            _logger = logger;
        }
 
        // GET: api/companies
        [HttpGet]
        public async Task<ActionResult<List<Company>>> Get()
        {
            try
            {
                List<Company> companies = await _companyService.Get();
                return Ok(companies);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van companies, Get: api/chats");
                return Problem("Problem retrieving all instances of a Company object"); // Logging
            }
        }

        // GET: api/companies/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                Company? company = await _companyService.GetById(id);
                if (company == null)
                {
                    return NotFound(); // Return 404 
                }
                return Ok(company);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van companies, Get: api/chats");
                return Problem("Problem retrieving a Company object"); // Logging  
            }
        }

        // POST: api/companies
        [HttpPost]
        public async Task<ActionResult<Company>> Create([FromBody] Company company)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return CreatedAtRoute("Get", new { id = company.CompanyId }, await _companyService.Create(company));

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van companies, Get: api/chats");
                return Problem("Problem posting a Company object"); // Logging
            }
        }

        // PUT: api/companies/id/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Company company)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                Company? oldCompany = await _companyService.GetById(id);
                if (oldCompany == null)
                {
                    return NotFound(); // Return 404 if the Company is not found
                }
                await _companyService.Update(id, company);
                return NoContent(); // Return 204
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fout bij het ophalen van companies, Get: api/chats");
                return Problem("Problem updating a Company object"); // Logging
            }
        }

        // DELETE: api/companies/id/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Company? company = await _companyService.GetById(id);
                if (company == null)
                {
                    return NotFound(); // Return 404
                }

                await _companyService.Delete(id);
                return NoContent(); // Return 204
            }
            catch
            {
                return Problem("Problem deleting a Company object");
            }
        }
    }
}
