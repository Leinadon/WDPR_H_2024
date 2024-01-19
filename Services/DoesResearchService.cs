
namespace WPR
{
    public interface IDoesResearchService
    {
        Task<List<DoesResearch>> Get();
        Task<DoesResearch?> GetById(int id);
        Task<DoesResearch?> Create(DoesResearch doesResearch);
        Task Update(int id, DoesResearch doesResearch);
        Task Delete(int id);
    }

    public class DoesResearchService : IDoesResearchService
    {
        private readonly IDoesResearchRepository _doesResearchRepository;

        public DoesResearchService(IDoesResearchRepository doesResearchRepository)
        {
            this._doesResearchRepository = doesResearchRepository;
        }

        public async Task<List<DoesResearch>> Get()
        {
            return await _doesResearchRepository.Get();
        }

        public async Task<DoesResearch?> GetById(int id)
        {
            return await _doesResearchRepository.GetByID(id);
        }

        public async Task<DoesResearch?> Create(DoesResearch doesResearch)
        {
            return await _doesResearchRepository.Create(doesResearch);
        }

        public async Task Delete(int id)
        {
            await _doesResearchRepository.Delete(id);
        }

        public async Task Update(int id, DoesResearch doesResearch)
        {
            await _doesResearchRepository.Update(id, doesResearch);
        }
    }
}
