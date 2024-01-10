using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    public interface IUserService
    {
        Task<List<User>> Get();
        Task<User?> GetByID(int id);
        Task<User> Create(User user);
        Task Update(int id, User user);
        Task Delete(int id);

        // Aanvullende methoden voor Employee, Admin, Specialist
        Task<Employee?> GetEmployeeByID(int id);
        Task<Administrator?> GetAdminByID(int id);
        Task<Specialist?> GetSpecialistByID(int id);
        Task<Employee> CreateEmployee(Employee employee);
        Task<Administrator> CreateAdmin(Administrator admin);
        Task<Specialist> CreateSpecialist(Specialist specialist);
        Task UpdateEmployee(int id, Employee employee);
        Task UpdateAdmin(int id, Administrator admin);
        Task UpdateSpecialist(int id, Specialist specialist);
        Task DeleteEmployee(int id);
        Task DeleteAdmin(int id);
        Task DeleteSpecialist(int id);
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

        public async Task<Employee?> GetEmployeeByID(int id)
        {
            return await _userRepository.GetEmployeeByID(id);
        }

        public async Task<Administrator?> GetAdminByID(int id)
        {
            return await _userRepository.GetAdminByID(id);
        }

        public async Task<Specialist?> GetSpecialistByID(int id)
        {
            return await _userRepository.GetSpecialistByID(id);
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            return await _userRepository.CreateEmployee(employee);
        }

        public async Task<Administrator> CreateAdmin(Administrator admin)
        {
            return await _userRepository.CreateAdmin(admin);
        }

        public async Task<Specialist> CreateSpecialist(Specialist specialist)
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

        public async Task DeleteEmployee(int id)
        {
            await _userRepository.DeleteEmployee(id);
        }

        public async Task DeleteAdmin(int id)
        {
            await _userRepository.DeleteAdmin(id);
        }

        public async Task DeleteSpecialist(int id)
        {
            await _userRepository.DeleteSpecialist(id);
        }
    }
}
