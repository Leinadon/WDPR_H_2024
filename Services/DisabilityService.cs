namespace WPR
{
    public interface IDisabilityService
    {
        Task<List<Disability>> Get();
        Task<Disability?> GetById(int id);
        Task<Disability?> Create(Disability disability);
        Task Update(int id, Disability disability);
        Task Delete(int id);
    }

    public class DisabilityService : IDisabilityService
    {
        private readonly IDisabilityRepository _disabilityRepository;

        public DisabilityService(IDisabilityRepository disabilityRepository)
        {
            this._disabilityRepository = disabilityRepository;
        }

        public async Task<List<Disability>> Get()
        {
            return await _disabilityRepository.Get();
        }

        public async Task<Disability?> GetById(int id)
        {
            return await _disabilityRepository.GetByID(id);
        }

        public async Task<Disability?> Create(Disability disability)
        {
            return await _disabilityRepository.Create(disability);
        }

        public async Task Delete(int id)
        {
            await _disabilityRepository.Delete(id);
        }

        public async Task Update(int id, Disability disability)
        {
            await _disabilityRepository.Update(id, disability);
        }
    }
}