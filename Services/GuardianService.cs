namespace WPR
{
    public interface IGuardianService
    {
        Task<List<Guardian>> Get();
        Task<Guardian?> GetById(int Id);
        Task<Guardian?> Create(Guardian guardian);
        Task Update(int id, Guardian guardian);
        Task Delete(int Id);
    }

    public class GuardianService : IGuardianService
    {
        private readonly IGuardianRepository _guardianRepository;

        public GuardianService(IGuardianRepository guardianRepository)
        {
            this._guardianRepository = guardianRepository;
        }

        public async Task<List<Guardian>> Get()
        {
            return await _guardianRepository.Get();
        }

        public async Task<Guardian?> GetById(int Id)
        {
            return await _guardianRepository.GetByID(Id);
        }

        public async Task<Guardian?> Create(Guardian guardian)
        {
            return await _guardianRepository.Create(guardian);
        }

        public async Task Delete(int Id)
        {
            await _guardianRepository.Delete(Id);
        }

        public async Task Update(int id, Guardian guardian)
        {
            await _guardianRepository.Update(id, guardian);
        }
    }
}