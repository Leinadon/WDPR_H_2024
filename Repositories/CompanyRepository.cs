using Microsoft.EntityFrameworkCore;
using WPR.Data;
using WPR.Models;

namespace WPR
{
    public interface ICompanyRepository
    {
        Task<List<Company>> Get();
        Task<Company> GetById(int id);
        Task<Company> Create(Company company);
        Task Update(int id, Company company);
        Task Delete(int id);
    }

    public class CompanyRepository: ICompanyRepository
    {
        private readonly WPRDbContext _dbContext;

        public CompanyRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Company>> Get()
        {
            return await _dbContext.Companies.ToListAsync();
        }

        public async Task<Company> GetById(int id)
        {
            return await _dbContext.Companies.FirstAsync(c => c.CompanyId == id);
        }

        public async Task<Company> Create(Company company)
        {
            _dbContext.Companies.Add(company);
            await _dbContext.SaveChangesAsync();
            return company;
        }

        public async Task Update(int id, Company company)
        {
            _dbContext.Update(company);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Company company = await _dbContext.Companies.FirstAsync(c => c.CompanyId == id);

            // TODO

            _dbContext.Companies.Remove(company);
            await _dbContext.SaveChangesAsync();
        }
    }
}
