using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    public interface IUserRepository
    {
        Task<List<User>> Get();
        Task<User?> GetByID(int id);
        Task<User?> GetByIDString(string id);
        Task<User> Create(User user);
        Task Update(int id, User user);
        Task Delete(int id);

        //aanvullende methodes voor de childs
        Task<Employee?> GetEmployeeByID(int id);
        Task<Administrator?> GetAdminByID(int id);
        Task<Specialist?> GetSpecialistByID(int id);
        Task<User> GetByEmail(string email);
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

        public async Task<User?> GetByID(int id)
        {
            User? user =await _dbContext.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Id.Equals(id.ToString()));
            if(user != null){
                return user;
            }else{
                throw new InvalidOperationException($"User with ID {id} not found");
            }
        }
        public async Task<User?> GetByIDString(string id)
        {
            User? user =await _dbContext.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Id.Equals(id.ToString()));
            if(user != null){
                return user;
            }else{
                throw new InvalidOperationException($"User with ID {id} not found");
            }
        }


        public async Task<User> Create(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task Delete(int id)
        {
            User? user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id.Equals(id.ToString()));
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Researh with ID {id} not found for Delete");
            }
        }

        public async Task Update(int id, User user)
        {
            User? oldUser = await _dbContext.Users.FindAsync(id);
            if (oldUser != null)
            {
                _dbContext.Update(oldUser);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"User with ID {id} not found for update.");
            }
        }

        public async Task<Employee?> GetEmployeeByID(int id)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(e => e.Id.Equals(id.ToString()));
        }

        public async Task<Administrator?> GetAdminByID(int id)
        {
            return await _dbContext.Administrators.FirstOrDefaultAsync(e => e.Id.Equals(id.ToString()));
        }

        public async Task<Specialist?> GetSpecialistByID(int id)
        {
            return await _dbContext.Specialists.FirstOrDefaultAsync(e => e.Id.Equals(id.ToString()));
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            await _dbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Administrator> CreateAdmin(Administrator admin)
        {
            _dbContext.Administrators.Add(admin);
            await _dbContext.SaveChangesAsync();
            return admin;
        }

        public async Task<Specialist> CreateSpecialist(Specialist specialist)
        {
            _dbContext.Specialists.Add(specialist);
            await _dbContext.SaveChangesAsync();
            return specialist;
        }

        public async Task UpdateEmployee(int id, Employee employee)
        {
            Employee? odlEmployee = await _dbContext.Employees.FindAsync(id);
            if(odlEmployee != null){
                _dbContext.Update(employee);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Employee with id {id} not found for update.");
            } 
        }

        public async Task UpdateAdmin(int id, Administrator admin)
        {
            Administrator? oldAdmin = await _dbContext.Administrators.FindAsync(id);
            if(oldAdmin != null){
                _dbContext.Update(oldAdmin);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Admin with id {id} not found for update.");
            }
        }

        public async Task UpdateSpecialist(int id, Specialist specialist)
        {
            Specialist? oldSpecialist = await _dbContext.Specialists.FindAsync(id);
            if(oldSpecialist != null){
                _dbContext.Update(oldSpecialist);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Specialist with id {id} not found for update.");
            }
        }

        public async Task DeleteEmployee(int id)
        {
            Employee? employee = await _dbContext.Employees.FirstOrDefaultAsync(e => e.Id.Equals(id.ToString()));
            if (employee != null){
                _dbContext.Employees.Remove(employee);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Employee with id {id} not found for update.");
            } 
        }

        public async Task DeleteAdmin(int id)
        {
            Administrator? administrator = await _dbContext.Administrators.FirstOrDefaultAsync(a => a.Id.Equals(id.ToString()));
            if (administrator != null){
                _dbContext.Administrators.Remove(administrator);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Admin with id {id} not found for update.");
            }
        }

        public async Task DeleteSpecialist(int id)
        {
            Specialist? specialist = await _dbContext.Specialists.FirstOrDefaultAsync(s => s.Id.Equals(id.ToString()));
            if(specialist != null){
                _dbContext.Specialists.Remove(specialist);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Specialist with id {id} not found for update.");
            }
        }

        public async Task<User> GetByEmail(string email)
        {
            User? user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));
            if(user != null){
                return user;
            }else{
                throw new InvalidOperationException($"User not found with email");
            }
        }
    }
}
