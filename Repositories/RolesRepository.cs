using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;

namespace WPR
{

    public interface IRoleRepository
    {
        
        Task<List<Roles>> Get();
        Task<Roles?> GetById(int id);
        

    }

    public class RoleRepository: IRoleRepository
    {

        private readonly WPRDbContext _dbContext;

        public RoleRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Roles>> Get()
        {
            return await _dbContext.Roles.ToListAsync();
        }

        public async Task<Roles?> GetById(int id)
        {
            Roles? roles = await _dbContext.Roles.FirstOrDefaultAsync(r => r.ID == id);
            if(roles != null){
                return roles;
            } else {
                throw new InvalidOperationException($"Roles with ID {id} not found");
            }
        }
    }
}