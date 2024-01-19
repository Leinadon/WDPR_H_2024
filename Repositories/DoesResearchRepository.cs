using Microsoft.EntityFrameworkCore;


namespace WPR
{
    public interface IDoesResearchRepository
    {
        Task<List<DoesResearch>> Get();
        Task<DoesResearch?> GetByID(int id);
        Task<DoesResearch> Create(DoesResearch doesResearch);
        Task Update(int id, DoesResearch doesResearch);
        Task Delete(int id);
    }

    public class DoesResearchRepository : IDoesResearchRepository
    {
        private readonly WPRDbContext _dbContext;

        public DoesResearchRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<DoesResearch>> Get()
        {
            return await _dbContext.DoesResearches.ToListAsync();
        }

        public async Task<DoesResearch?> GetByID(int id)
        {
            return await _dbContext.DoesResearches.FirstOrDefaultAsync(d => d.ID == id);
        }

        public async Task<DoesResearch> Create(DoesResearch doesResearch)
        {
            _dbContext.DoesResearches.Add(doesResearch);
            await _dbContext.SaveChangesAsync();
            return doesResearch;
        }

        public async Task Delete(int id)
        {
            DoesResearch? doesResearch = await _dbContext.DoesResearches.FirstOrDefaultAsync(d => d.ID == id);
            if (doesResearch != null)
            {
                _dbContext.DoesResearches.Remove(doesResearch);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(int id, DoesResearch doesResearch)
        {
            DoesResearch? oldDoesResearch = await _dbContext.DoesResearches.FindAsync(id);
            if (oldDoesResearch != null)
            {
                _dbContext.Update(doesResearch);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"DoesResearch with ID {id} not found for update.");
            }
        }
    }
}
