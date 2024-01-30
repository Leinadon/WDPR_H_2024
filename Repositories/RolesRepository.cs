using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;

namespace WPR
{
    public interface IRoleRepository
    {
        Task<List<Roles>> GetRolesFromDatabase();
        Task<Roles?> GetById(int id);
    }

    public class RoleRepository : IRoleRepository
    {
        private readonly WPRDbContext _rolesRepository;

        public RoleRepository(WPRDbContext rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }

        public async Task<List<Roles>> GetRolesFromDatabase()
        {

            return await _rolesRepository.Roles.ToListAsync();
        }

        public async Task<Roles?> GetById(int id)
        {

            return await _rolesRepository.Roles.FindAsync(id);
        }
    }


}