using Microsoft.EntityFrameworkCore;


namespace WPR
{
    public interface IOnlineAssignmentResultRepository
    {
        Task<List<OnlineAssignmentResult>> Get();
        Task<OnlineAssignmentResult?> GetById(int id);
        Task<OnlineAssignmentResult> Create(OnlineAssignmentResult onlineAssignmentResult);
        Task Update(int id, OnlineAssignmentResult onlineAssignmentResult);
        Task Delete(int id);
    }
    
    public class OnlineAssignmentResultRepository : IOnlineAssignmentResultRepository
    {
        private readonly WPRDbContext _dbContext;

        public OnlineAssignmentResultRepository(WPRDbContext dbContext){
            this._dbContext = dbContext;
        }

        public async Task<OnlineAssignmentResult> Create(OnlineAssignmentResult onlineAssignmentResult)
        {
            _dbContext.OnlineAssignmentResults.Add(onlineAssignmentResult);
            await _dbContext.SaveChangesAsync();
            return onlineAssignmentResult;
        }

        public async Task Delete(int id)
        {
            OnlineAssignmentResult? oldOnlineAssignmentResult = await _dbContext.OnlineAssignmentResults.FindAsync(id);
            if(oldOnlineAssignmentResult != null)
            {
                _dbContext.OnlineAssignmentResults.Remove(oldOnlineAssignmentResult);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<OnlineAssignmentResult>> Get()
        {
            return await _dbContext.OnlineAssignmentResults.ToListAsync();
        }

        public async Task<OnlineAssignmentResult?> GetById(int id)
        {
            return await _dbContext.OnlineAssignmentResults.FirstOrDefaultAsync(o => o.ID == id);
        }

        public async Task Update(int id, OnlineAssignmentResult onlineAssignmentResult)
        {
            OnlineAssignmentResult? oldOnlineAssignmentResult = await _dbContext.OnlineAssignmentResults.FindAsync(id);
            if(oldOnlineAssignmentResult != null){
                _dbContext.Update(oldOnlineAssignmentResult);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"OnlineAssignmentResult with id {id} not found for update.");
            }
        }
    }
}