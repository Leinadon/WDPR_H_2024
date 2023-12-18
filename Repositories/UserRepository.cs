using Microsoft.EntityFrameworkCore;
using WPR.Data;

namespace WPR
{
    public interface IUserRepository
    {
        Task<List<User>> Get();
        Task<User> GetById(int id);
    }

    public class UserRepository : IUserRepository
    {
        private readonly WPRDbContext _dbContext;

        public UserRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<User>> Get()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _dbContext.Users.FirstAsync(c => c.Id == id);
        }
    }
}
