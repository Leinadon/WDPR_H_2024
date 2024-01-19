using Microsoft.EntityFrameworkCore;


namespace WPR
{
    public interface IDisabilityTypeRepository
    {
        Task<List<DisabilityType>> Get();
        Task<DisabilityType?> GetByID(int id);
        Task<DisabilityType> Create(DisabilityType disabilityType);
        Task Update(int id, DisabilityType disabilityType);
        Task Delete(int id);
    }

    public class DisabilityTypeRepository : IDisabilityTypeRepository
    {
        private readonly WPRDbContext _dbContext;

        public DisabilityTypeRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<DisabilityType>> Get()
        {
            return await _dbContext.DisabilityTypes.ToListAsync();
        }

        public async Task<DisabilityType?> GetByID(int id)
        {
            return await _dbContext.DisabilityTypes.FirstOrDefaultAsync(dt => dt.ID == id);
        }

        public async Task<DisabilityType> Create(DisabilityType disabilityType)
        {
            _dbContext.DisabilityTypes.Add(disabilityType);
            await _dbContext.SaveChangesAsync();
            return disabilityType;
        }

        public async Task Delete(int id)
        {
            DisabilityType? disabilityType = await _dbContext.DisabilityTypes.FirstOrDefaultAsync(dt => dt.ID == id);
            if (disabilityType != null)
            {
                _dbContext.DisabilityTypes.Remove(disabilityType);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"DisablilityType wiht ID {id} not found for Delete");
            }
        }

        public async Task Update(int id, DisabilityType disabilityType)
        {
            DisabilityType? oldDisabilityType = await _dbContext.DisabilityTypes.FindAsync(id);
            if (oldDisabilityType != null)
            {
                _dbContext.Update(disabilityType);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"DisabilityType with ID {id} not found for update.");
            }
        }
    }
}
