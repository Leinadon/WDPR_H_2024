
namespace WPR
{
    public interface IUserService
    {
        Task<List<OurUser>> Get();
        Task<OurUser?> GetByIDString(string id);
        Task<OurUser?> GetByID(int id);
        Task<OurUser> Create(OurUser user);
        Task Update(int id, OurUser user);
        Task Delete(int id);
        Task<OurUser> GetByEmail(string email);
        Task<OurUser> CreateEmployee(OurUser employee);
        Task<OurUser> CreateAdmin(OurUser admin);
        Task<OurUser> CreateSpecialist(OurUser specialist);
        Task UpdateEmployee(int id, OurUser employee);
        Task UpdateAdmin(int id, OurUser admin);
        Task UpdateSpecialist(int id, OurUser specialist);
    }


    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<List<OurUser>> Get()
        {
            return await _userRepository.Get();
        }

        public async Task<OurUser?> GetByID(int id)
        {
            return await _userRepository.GetByID(id);
        }
        public async Task<OurUser?> GetByIDString(string id)
        {
            return await _userRepository.GetByIDString(id);
        }
        public async Task<OurUser> Create(OurUser user)
        {
            return await _userRepository.Create(user);
        }

        public async Task Delete(int id)
        {
            await _userRepository.Delete(id);
        }

        public async Task Update(int id, OurUser user)
        {
            await _userRepository.Update(id, user);
        }

        public async Task<OurUser?> GetEmployeeByID(int id)
        {
            return await _userRepository.GetByID(id);
        }

        

        

        public async Task<OurUser> CreateEmployee(OurUser employee)
        {
            return await _userRepository.CreateEmployee(employee);
        }

        public async Task<OurUser> CreateAdmin(OurUser admin)
        {
            return await _userRepository.CreateAdmin(admin);
        }

        public async Task<OurUser> CreateSpecialist(OurUser specialist)
        {
            return await _userRepository.CreateSpecialist(specialist);
        }

        public async Task UpdateEmployee(int id, OurUser employee)
        {
            await _userRepository.UpdateEmployee(id, employee);
        }

        public async Task UpdateAdmin(int id, OurUser admin)
        {
            await _userRepository.UpdateAdmin(id, admin);
        }

        public async Task UpdateSpecialist(int id, OurUser specialist)
        {
            await _userRepository.UpdateSpecialist(id, specialist);
        }


        public async Task<OurUser> GetByEmail(string email)
        {
            return await _userRepository.GetByEmail(email);
        }
    }
}
