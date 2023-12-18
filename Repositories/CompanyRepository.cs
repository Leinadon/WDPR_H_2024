using Microsoft.EntityFrameworkCore;
using WPR.Data;

namespace WPR
{
    public interface ICompanyRepository
    {
        Task<List<Company>> Get();
        Task<Company> GetById(int id);
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
            return await _dbContext.Companies.FirstAsync(c => c.Id == id);
        }
    }
}
