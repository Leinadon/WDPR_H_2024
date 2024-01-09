using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Expressions;

namespace WPR
{
    public interface IResearchRepository
{
    // Global
    Task<List<Research>> Get();
    Task<Research?> GetById(int id);
    Task Delete(int id);

    // Questionnaire
    Task Create(Questionnaire questionnaire);
    Task Update(int id, Questionnaire questionnaire);
    
    // Interview
    Task Create(Interview interview);
    Task Update(int id, Interview interview);

    // Online
    Task Create(OnlineAssignment online);
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
            .Where(r => r.ResearchID == id)
            .FirstOrDefaultAsync();
    }

    public async Task Delete(int id)
    {
        Research? research = await _dbContext.Researches.FirstAsync(r => r.ResearchID == id);

        // TODO: if research not found: return error

        _dbContext.Researches.Remove(research);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Create(Questionnaire questionnaire)
    {
        _dbContext.Questionnaires.Add(questionnaire);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Update(int id, Questionnaire questionnaire)
    {
        _dbContext.Update(questionnaire);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Create(Interview interview)
    {
        _dbContext.Interviews.Add(interview);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Update(int id, Interview interview)
    {
        _dbContext.Update(interview);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Create(OnlineAssignment onlineAssignment)
    {
        _dbContext.OnlineAssignments.Add(onlineAssignment);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Update(int id, OnlineAssignment onlineAssignment)
    {
        _dbContext.Update(onlineAssignment);
        await _dbContext.SaveChangesAsync();
    }
}
}

