using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public interface IDisabilityRepository
    {
        Task<List<Disability>> Get();
        Task<Disability?> GetByID(int id);
        Task<Disability> Create(Disability disability);
        Task Update(int id, Disability disability);
        Task Delete(int id);
    }

    public class DisabilityRepository : IDisabilityRepository
    {
        private readonly WPRDbContext _dbContext;

        public DisabilityRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Disability>> Get()
        {
            return await _dbContext.Disabilities.ToListAsync();
        }

        public async Task<Disability?> GetByID(int id)
        {
            return await _dbContext.Disabilities.FirstOrDefaultAsync(d => d.DisabilityId == id);
        }

        public async Task<Disability> Create(Disability disability)
        {
            _dbContext.Disabilities.Add(disability);
            await _dbContext.SaveChangesAsync();
            return disability;
        }

        public async Task Delete(int id)
        {
            Disability? disability = await _dbContext.Disabilities.FirstOrDefaultAsync(d => d.DisabilityId == id);
            if (disability != null)
            {
                _dbContext.Disabilities.Remove(disability);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(int id, Disability disability)
        {
            Disability? oldDisability = await _dbContext.Disabilities.FindAsync(id);
            if (oldDisability != null)
            {
                _dbContext.Update(disability);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"Disability with ID {id} not found for update.");
            }
        }
    }
}