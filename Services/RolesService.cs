using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    public interface IRolesService
    {
        Task<List<Roles>> GetRoles();
        Task<Roles?> GetById(int id);
    }

    public class RolesService : IRolesService
    {
        private readonly IRoleRepository _rolesRepository;

        public RolesService(IRoleRepository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }

        public async Task<Roles?> GetById(int id)
        {
            return await _rolesRepository.GetById(id);
        }

        public async Task<List<Roles>> GetRoles()
        {
            return await _rolesRepository.GetRolesFromDatabase();
        }
    }
}

