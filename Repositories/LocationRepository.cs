using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public interface ILocationRepository
    {
        Task<Location?> GetByID(int id);
        Task<Location?> GetBySpecialist(Specialist specialist);
        Task<Location?> GetByCompany(Company company);
        Task<Location> Create(Location location);
        Task Update(int id, Location location);
        Task Delete(int id);
    }

    public class LocationRepository : ILocationRepository
    {
        private readonly WPRDbContext _dbContext;

        public LocationRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        /// <summary>
        /// Voegt een Location toe aan de db
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public async Task<Location> Create(Location location)
        {
            _dbContext.Locations.Add(location);
            await _dbContext.SaveChangesAsync();
            return location;
        }
        /// <summary>
        /// Delete een Location uit de db
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task Delete(int id)
        {
            Location? location = await _dbContext.Locations.FirstOrDefaultAsync(l => l.Id == id);
            if(location != null)
            {
                _dbContext.Locations.Remove(location);
                await _dbContext.SaveChangesAsync();
            }
        }
        /// <summary>
        /// Haal de Locatie op van een Company
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Location?> GetByCompany(Company company)
        {
            return await _dbContext.Locations.FirstOrDefaultAsync(l => l.Id == company.CompanyId);
        }
        /// <summary>
        /// Haal de locatie op met een id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Location?> GetByID(int id)
        {
            return await _dbContext.Locations.FirstOrDefaultAsync(l => l.Id == id);
            
        }
        /// <summary>
        /// Haalt de locatie op van een specialist
        /// </summary>
        /// <param name="specialist"></param>
        /// <returns></returns>
        public async Task<Location?> GetBySpecialist(Specialist specialist)
        {
            return await _dbContext.Locations.FirstOrDefaultAsync(l => l.Id == specialist.LocationId);
        }
        /// <summary>
        /// Past een locatie aan
        /// </summary>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <returns></returns>
        public async Task Update(int id, Location location)
        {
            Location? oldLocation = await _dbContext.Locations.FindAsync(id);
            if(oldLocation != null)
            {
                _dbContext.Update(location);
                await _dbContext.SaveChangesAsync();  
            }
            else
            {
                throw new InvalidOperationException($"Location with ID {id} not found for update.");
            }
        }
    }
}