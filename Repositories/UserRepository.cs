using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
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
        Task<User> GetByEmail(string email);
        Task<User> CreateEmployee(User employee);
        Task<User> CreateAdmin(User admin);
        Task<User> CreateSpecialist(User specialist);
        Task UpdateEmployee(int id, User employee);
        Task UpdateAdmin(int id, User admin);
        Task UpdateSpecialist(int id, User specialist);
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
                _dbContext.Update(user);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"User with ID {id} not found for update.");
            }
        }
        

        public async Task<User> CreateEmployee(User employee)
        {
            _dbContext.Users.Add(employee);
            await _dbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<User> CreateAdmin(User admin)
        {
            _dbContext.Users.Add(admin);
            await _dbContext.SaveChangesAsync();
            return admin;
        }

        public async Task<User> CreateSpecialist(User specialist)
        {
            _dbContext.Users.Add(specialist);
            await _dbContext.SaveChangesAsync();
            return specialist;
        }

        public async Task UpdateEmployee(int id, User employee)
        {
            User? odlEmployee = await _dbContext.Users.FindAsync(id);
            if(odlEmployee != null){
                _dbContext.Update(employee);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Employee with id {id} not found for update.");
            } 
        }

        public async Task UpdateAdmin(int id, User admin)
        {
            User? oldAdmin = await _dbContext.Users.FindAsync(id);
            if(oldAdmin != null){
                _dbContext.Update(admin);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Admin with id {id} not found for update.");
            }
        }

        public async Task UpdateSpecialist(int id, User specialist)
        {
            User? oldSpecialist = await _dbContext.Users.FindAsync(id);
            if(oldSpecialist != null){
                _dbContext.Update(specialist);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Specialist with id {id} not found for update.");
            }
        }

        public async Task DeleteEmployee(int id)
        {
            User? employee = await _dbContext.Users.FirstOrDefaultAsync(e => e.Id.Equals(id.ToString()));
            if (employee != null){
                _dbContext.Users.Remove(employee);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Employee with id {id} not found for update.");
            } 
        }

        public async Task DeleteAdmin(int id)
        {
            User? administrator = await _dbContext.Users.FirstOrDefaultAsync(a => a.Id.Equals(id.ToString()));
            if (administrator != null){
                _dbContext.Users.Remove(administrator);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Admin with id {id} not found for update.");
            }
        }

        public async Task DeleteSpecialist(int id)
        {
            User? specialist = await _dbContext.Users.FirstOrDefaultAsync(s => s.Id.Equals(id.ToString()));
            if(specialist != null){
                _dbContext.Users.Remove(specialist);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Specialist with id {id} not found for update.");
            }
        }

        public async Task<User> GetByEmail(string email)
        {
            User? user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email != null  && u.Email.Equals(email));
            if(user != null){
                return user;
            }else{
                throw new InvalidOperationException($"User not found with email");
            }
        }
    }
}
