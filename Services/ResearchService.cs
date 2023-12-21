using WPR;

public interface IResearchService
{
    Task<List<Research>> Get();
    Task<Research> GetById(int id);
    Task<Research> Create(Research questionnaire);
    Task Update(int id, Research questionnaire);
    Task Delete(int id);
}

public class ResearchService : IResearchService
{
    private readonly IResearchRepository _researchRepository;

    public ResearchService(IResearchRepository researchRepository)
    {
        _researchRepository = researchRepository;
    }

    public async Task<List<Research>> Get()
    {
        return await _researchRepository.Get();
    }

    public async Task<Research> GetById(int id)
    {
        return await _researchRepository.GetById(id);
    }

    public async Task<Research> Create(Research research)
    {
        return await _researchRepository.Create(research);
    }

    public async Task Update(int id, Research research)
    {
        await _researchRepository.Update(id, research);
    }

    public async Task Delete(int id)
    {
        await _researchRepository.Delete(id);
    }
}