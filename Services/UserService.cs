
namespace WPR
{
    public interface IUserService
    {
        Task<List<User>> Get();
        Task<User?> GetByIDString(string id);
        Task<User?> GetByID(int id);
        Task<User> Create(User user);
        Task Update(int id, User user);
        Task Delete(int id);
        Task<User> GetByEmail(string email);
        Task<User> CreateEmployee(Employee employee);
        Task<User> CreateAdmin(Administrator admin);
        Task<User> CreateSpecialist(Specialist specialist);
        Task UpdateEmployee(int id, Employee employee);
        Task UpdateAdmin(int id, Administrator admin);
        Task UpdateSpecialist(int id, Specialist specialist);
    }


    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<List<User>> Get()
        {
            return await _userRepository.Get();
        }

        public async Task<User?> GetByID(int id)
        {
            return await _userRepository.GetByID(id);
        }
        public async Task<User?> GetByIDString(string id)
        {
            return await _userRepository.GetByIDString(id);
        }
        public async Task<User> Create(User user)
        {
            return await _userRepository.Create(user);
        }

        public async Task Delete(int id)
        {
            await _userRepository.Delete(id);
        }

        public async Task Update(int id, User user)
        {
            await _userRepository.Update(id, user);
        }

        public async Task<User?> GetEmployeeByID(int id)
        {
            return await _userRepository.GetByID(id);
        }

        

        

        public async Task<User> CreateEmployee(Employee employee)
        {
            return await _userRepository.CreateEmployee(employee);
        }

        public async Task<User> CreateAdmin(Administrator admin)
        {
            return await _userRepository.CreateAdmin(admin);
        }

        public async Task<User> CreateSpecialist(Specialist specialist)
        {
            return await _userRepository.CreateSpecialist(specialist);
        }

        public async Task UpdateEmployee(int id, Employee employee)
        {
            await _userRepository.UpdateEmployee(id, employee);
        }

        public async Task UpdateAdmin(int id, Administrator admin)
        {
            await _userRepository.UpdateAdmin(id, admin);
        }

        public async Task UpdateSpecialist(int id, Specialist specialist)
        {
            await _userRepository.UpdateSpecialist(id, specialist);
        }


        public async Task<User> GetByEmail(string email)
        {
            return await _userRepository.GetByEmail(email);
        }
    }
}
