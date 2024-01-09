using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public interface IUserRepository
    {
        Task<List<User>> Get();
        Task<User?> GetById(string id);
    }

    public class UserRepository : IUserRepository
    {
        private readonly WPRDbContext _dbContext;

        public UserRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        /// <summary>
        /// Haalt een lijst op van alle gebruikers
        /// </summary>
        /// <returns></returns>
        public async Task<List<User>> Get()
        {
            return await _dbContext.Users.ToListAsync();
        }
        /// <summary>
        /// Haalt een user op met een ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<User?> GetById(string id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        } 
    }
}
