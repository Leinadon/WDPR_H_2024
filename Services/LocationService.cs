using SQLitePCL;

namespace WPR
{
    public interface ILocationService
    {
        Task<List<Location>> Get();
        Task<Location?> GetById(int Id);
        Task Create(Location location);
        Task Update(int id, Location location);
        Task Delete(int Id);
    }

    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository){
            this._locationRepository = locationRepository;
        }
        public async Task<List<Location>> Get(){
            return await _locationRepository.Get();
        }
        public async Task<Location?> GetById(int Id)
        {
            return await _locationRepository.GetByID(Id);

        }
        public async Task Create(Location location)
        {
            await _locationRepository.Create(location);
        }

        public async Task Delete(int Id)
        {
            await _locationRepository.Delete(Id);
        }
        public async Task Update(int id, Location location)
        {
            await _locationRepository.Update(id,location);
        }
    }
}