using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public interface IGuardianRepository
    {
        Task<List<Guardian>> Get();
        Task<Guardian?> GetByID(int id);
        Task<Guardian> Create(Guardian guardian);
        Task Update(int id, Guardian guardian);
        Task Delete(int id);
    }

    public class GuardianRepository : IGuardianRepository
    {
        private readonly WPRDbContext _dbContext;

        public GuardianRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Guardian>> Get()
        {
            return await _dbContext.Guardians.ToListAsync();
        }

        public async Task<Guardian?> GetByID(int id)
        {
            return await _dbContext.Guardians.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<Guardian> Create(Guardian guardian)
        {
            _dbContext.Guardians.Add(guardian);
            await _dbContext.SaveChangesAsync();
            return guardian;
        }

        public async Task Delete(int id)
        {
            Guardian? guardian = await _dbContext.Guardians.FirstOrDefaultAsync(g => g.Id == id);
            if (guardian != null)
            {
                _dbContext.Guardians.Remove(guardian);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(int id, Guardian guardian)
        {
            Guardian? oldGuardian = await _dbContext.Guardians.FindAsync(id);
            if (oldGuardian != null)
            {
                _dbContext.Update(guardian);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"Guardian with ID {id} not found for update.");
            }
        }
    }
}