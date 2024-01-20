using Microsoft.EntityFrameworkCore;


namespace WPR
{
    public interface ICompanyRepository
    {
        Task<List<Company>> Get();
        Task<Company?> GetByID(int id);
        Task<Company> Create(Company company);
        Task Update(int id, Company company);
        Task Delete(int id);
    }

    public class CompanyRepository : ICompanyRepository
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

        public async Task<Company?> GetByID(int id)
        {
            return await _dbContext.Companies.FirstOrDefaultAsync(c => c.CompanyId == id);
        }

        public async Task<Company> Create(Company company)
        {
            _dbContext.Companies.Add(company);
            await _dbContext.SaveChangesAsync();
            return company;
        }

        public async Task Delete(int id)
        {
            Company? company = await _dbContext.Companies.FirstOrDefaultAsync(c => c.CompanyId == id);
            if (company != null)
            {
                _dbContext.Companies.Remove(company);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(int id, Company company)
        {
            Company? oldCompany = await _dbContext.Companies.FindAsync(id);
            if (oldCompany != null)
            {
                oldCompany.Name = company.Name; // Update other properties as needed
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"Company with ID {id} not found for update.");
            }
        }
    }
}
