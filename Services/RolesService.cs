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

        public Task<List<Roles>> GetRoles()
        {
            throw new NotImplementedException();
        }
    }
}
