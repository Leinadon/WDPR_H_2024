using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Expressions;

namespace WPR;

public interface IResearchRepository
{
    // Global
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

public class ResearchRepository: IResearchRepository
{
    private readonly WPRDbContext _dbContext;

    public ResearchRepository(WPRDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    public async Task<List<Research>> Get()
    {

        return await _dbContext.Researches.ToListAsync();
    }

    public async Task<Research?> GetById(int id)
    {
        return await _dbContext.Researches
            .Where(r => r.ResearchId == id)
            .FirstOrDefaultAsync();
    }

    public async Task Delete(int id)
    {
        Research? research = await _dbContext.Researches.FirstAsync(r => r.ResearchId == id);

        // TODO: if research not found: return error

        _dbContext.Researches.Remove(research);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Questionnaire> Create(Questionnaire questionnaire)
    {
        _dbContext.Questionnaires.Add(questionnaire);
        await _dbContext.SaveChangesAsync();
        return questionnaire;
    }

    public async Task Update(int id, Questionnaire questionnaire)
    {
        _dbContext.Update(questionnaire);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Interview> Create(Interview interview)
    {
        _dbContext.Interviews.Add(interview);
        await _dbContext.SaveChangesAsync();
        return interview;
    }

    public async Task Update(int id, Interview interview)
    {
        _dbContext.Update(interview);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<OnlineAssignment> Create(OnlineAssignment onlineAssignment)
    {
        _dbContext.OnlineAssignment.Add(onlineAssignment);
        await _dbContext.SaveChangesAsync();
        return onlineAssignment;
    }

    public async Task Update(int id, OnlineAssignment onlineAssignment)
    {
        _dbContext.Update(onlineAssignment);
        await _dbContext.SaveChangesAsync();
    }
}