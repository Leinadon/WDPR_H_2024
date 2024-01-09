using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public interface IQuestionnaireRepository
    {
        Task<List<Questionnaire>> Get();
        Task<Questionnaire?> GetById(int id);
        Task<int> Create(Questionnaire questionnaire);
        Task Update(int id, Questionnaire questionnaire);
        Task Delete(int id);
    }

    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private readonly WPRDbContext _dbContext;

        public QuestionnaireRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Questionnaire>> Get()
        {
            return await _dbContext.Questionnaires.ToListAsync();
        }

        public async Task<Questionnaire?> GetById(int id)
        {
            return await _dbContext.Questionnaires.FindAsync(id);
        }

        public async Task<int> Create(Questionnaire questionnaire)
        {
            _dbContext.Questionnaires.Add(questionnaire);
            await _dbContext.SaveChangesAsync();
            return questionnaire.ResearchID;
        }

        public async Task Update(int id, Questionnaire questionnaire)
        {
            _dbContext.Update(questionnaire);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Questionnaire questionnaire = await _dbContext.Questionnaires.FirstAsync(q => q.ResearchID == id);
            _dbContext.Questionnaires.Remove(questionnaire);
            await _dbContext.SaveChangesAsync();
        }
    }
}
