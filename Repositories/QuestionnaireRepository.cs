using Microsoft.EntityFrameworkCore;
using WPR.Data;
using WPR.Models;

namespace WPR
{
    public interface IQuestionnaireRepository
    {
        Task<List<Questionnaire>> Get();
        Task<Questionnaire> GetById(int id);
        Task Create(Questionnaire questionnaire);
        Task Update(Questionnaire questionnaire);
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

        public async Task<Questionnaire> GetById(int id)
        {
            return await _dbContext.Questionnaires.FirstAsync(c => c.Id == id);
        }

        public async Task Create(Questionnaire questionnaire)
        {
            await _dbContext.Questionnaires.AddAsync(questionnaire);
        }

        public async Task Update(Questionnaire questionnaire)
        {
            
        }
    }
}
