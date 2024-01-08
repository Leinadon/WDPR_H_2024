using WPR;

public interface IResearchService
{
    Task<List<Research>> Get();
    Task<Research?> GetById(int id);
    Task Delete(int id);

    // Questionnaire
    Task<Questionnaire> Create(Questionnaire questionnaire);
    Task Update(int id, Questionnaire questionnaire);
    
    // Interview
    Task<Interview> Create(Interview interview);
    Task Update(int id, Interview interview);

    // Online
    Task<OnlineAssignment> Create(OnlineAssignment online);
    Task Update(int id, OnlineAssignment online);    
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

    public async Task<Research?> GetById(int id)
    {
        return await _researchRepository.GetById(id);
    }

    public async Task Delete(int id)
    {
        await _researchRepository.Delete(id);
    }

    public async Task<Questionnaire> Create(Questionnaire questionnaire)
    {
        return await _researchRepository.Create(questionnaire);
    }

    public async Task Update(int id, Questionnaire questionnaire)
    {
        await _researchRepository.Update(id, questionnaire);
    }

    public async Task<Interview> Create(Interview interview)
    {
        return await _researchRepository.Create(interview);
    }

    public async Task Update(int id, Interview interview)
    {
        await _researchRepository.Update(id, interview);
    }

    public async Task<OnlineAssignment> Create(OnlineAssignment onlineAssignment)
    {
        return await _researchRepository.Create(onlineAssignment);
    }

    public async Task Update(int id, OnlineAssignment onlineAssignment)
    {
        await _researchRepository.Update(id, onlineAssignment);
    }
}