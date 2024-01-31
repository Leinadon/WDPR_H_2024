using Microsoft.EntityFrameworkCore;


namespace WPR
{
    public interface IUserRepository
    {
        Task<List<OurUser>> Get();
        Task<OurUser?> GetByID(int id);
        Task<OurUser?> GetByIDString(string id);
        Task<OurUser> Create(OurUser OurUser);
        Task Update(int id, OurUser OurUser);
        Task Delete(int id);

        //aanvullende methodes voor de childs
        Task<OurUser> GetByEmail(string email);
        Task<OurUser> CreateEmployee(OurUser employee);
        Task<OurUser> CreateAdmin(OurUser admin);
        Task<OurUser> CreateSpecialist(OurUser specialist);
        Task UpdateEmployee(int id, OurUser employee);
        Task UpdateAdmin(int id, OurUser admin);
        Task UpdateSpecialist(int id, OurUser specialist);
    }

    public class UserRepository : IUserRepository
    {
        private readonly WPRDbContext _dbContext;

        public UserRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<OurUser>> Get()
        {
            return await _dbContext.
            OurUsers.ToListAsync();
        }

        public async Task<OurUser?> GetByID(int id)
        {
            OurUser? OurUser =await _dbContext.
            OurUsers.FirstOrDefaultAsync(u => u.Id.Equals(id.ToString()));
            if(OurUser != null){
                return OurUser;
            }else{
                throw new InvalidOperationException($"OurUser with ID {id} not found");
            }
        }
        public async Task<OurUser?> GetByIDString(string id)
        {
            OurUser? OurUser =await _dbContext.
            OurUsers.FirstOrDefaultAsync(u => u.Id.Equals(id.ToString()));
            if(OurUser != null){
                return OurUser;
            }else{
                throw new InvalidOperationException($"OurUser with ID {id} not found");
            }
        }


        public async Task<OurUser> Create(OurUser OurUser)
        {
            _dbContext.
            OurUsers.Add(OurUser);
            await _dbContext.SaveChangesAsync();
            return OurUser;
        }

        public async Task Delete(int id)
        {
            OurUser? OurUser = await _dbContext.
            OurUsers.FirstOrDefaultAsync(u => u.Id.Equals(id.ToString()));
            if (OurUser != null)
            {
                _dbContext.
                OurUsers.Remove(OurUser);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Researh with ID {id} not found for Delete");
            }
        }

        public async Task Update(int id, OurUser OurUser)
        {
            OurUser? oldOurUser = await _dbContext.
            OurUsers.FindAsync(id);
            if (oldOurUser != null)
            {
                _dbContext.Update(OurUser);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"OurUser with ID {id} not found for update.");
            }
        }
        

        public async Task<OurUser> CreateEmployee(OurUser employee)
        {
            _dbContext.
            OurUsers.Add(employee);
            await _dbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<OurUser> CreateAdmin(OurUser admin)
        {
            _dbContext.
            OurUsers.Add(admin);
            await _dbContext.SaveChangesAsync();
            return admin;
        }

        public async Task<OurUser> CreateSpecialist(OurUser specialist)
        {
            _dbContext.
            OurUsers.Add(specialist);
            await _dbContext.SaveChangesAsync();
            return specialist;
        }
        

        public async Task UpdateEmployee(int id, OurUser employee)
        {
            OurUser? odlEmployee = await _dbContext.
            OurUsers.FindAsync(id);
            if(odlEmployee != null){
                _dbContext.Update(employee);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Employee with id {id} not found for update.");
            } 
        }

        public async Task UpdateAdmin(int id, OurUser admin)
        {
            OurUser? oldAdmin = await _dbContext.
            OurUsers.FindAsync(id);
            if(oldAdmin != null){
                _dbContext.Update(admin);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Admin with id {id} not found for update.");
            }
        }

        public async Task UpdateSpecialist(int id, OurUser specialist)
        {
            OurUser? oldSpecialist = await _dbContext.
            OurUsers.FindAsync(id);
            if(oldSpecialist != null){
                _dbContext.Update(specialist);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Specialist with id {id} not found for update.");
            }
        }

        public async Task DeleteEmployee(int id)
        {
            OurUser? employee = await _dbContext.
            OurUsers.FirstOrDefaultAsync(e => e.Id.Equals(id.ToString()));
            if (employee != null){
                _dbContext.
                OurUsers.Remove(employee);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Employee with id {id} not found for update.");
            } 
        }

        public async Task DeleteAdmin(int id)
        {
            OurUser? administrator = await _dbContext.
            OurUsers.FirstOrDefaultAsync(a => a.Id.Equals(id.ToString()));
            if (administrator != null){
                _dbContext.
                OurUsers.Remove(administrator);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Admin with id {id} not found for update.");
            }
        }

        public async Task DeleteSpecialist(int id)
        {
            OurUser? specialist = await _dbContext.
            OurUsers.FirstOrDefaultAsync(s => s.Id.Equals(id.ToString()));
            if(specialist != null){
                _dbContext.
                OurUsers.Remove(specialist);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Specialist with id {id} not found for update.");
            }
        }

        public async Task<OurUser> GetByEmail(string email)
        {
            OurUser? OurUser = await _dbContext.
            OurUsers.FirstOrDefaultAsync(u => u.Email != null  && u.Email.Equals(email));
            if(OurUser != null){
                return OurUser;
            }else{
                throw new InvalidOperationException($"OurUser not found with email");
            }
        }
    }
}
