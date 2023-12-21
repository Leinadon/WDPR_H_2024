using System;
using Microsoft.EntityFrameworkCore;

namespace WPR;

public interface IResearchRepository
{
    Task<List<Research>> Get();
    Task<Research> GetById(int id);
    Task<Research> Create(Research questionnaire);
    Task Update(int id, Research questionnaire);
    Task Delete(int id);
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

    public async Task<Research> Create(Research research)
    {
        _dbContext.Researches.Add(research);

        await _dbContext.SaveChangesAsync();

        return research;
    }

    public async Task Update(int id, Research research)
    {
        _dbContext.Update(research);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        Research? research = await _dbContext.Researches.FirstAsync(r => r.ResearchId == id);

        // TODO: if research not found: return error

        _dbContext.Researches.Remove(research);
        await _dbContext.SaveChangesAsync();
    }
}