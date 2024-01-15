using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    public interface IQuestionRepository
    {
        Task<List<Question>> Get();
        Task<Question?> GetByID(int id);
        Task<Question> Create(Question question);
        Task Update(int id, Question question);
        Task Delete(int id);
    }

    public class QuestionRepository : IQuestionRepository
    {
        private readonly WPRDbContext _dbContext;

        public QuestionRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Question>> Get()
        {
            return await _dbContext.Questions.ToListAsync();
        }

        public async Task<Question?> GetByID(int id)
        {
            return await _dbContext.Questions.FirstOrDefaultAsync(q => q.ID == id);
        }

        public async Task<Question> Create(Question question)
        {
            _dbContext.Questions.Add(question);
            await _dbContext.SaveChangesAsync();
            return question;
        }

        public async Task Delete(int id)
        {
            Question? question = await _dbContext.Questions.FirstOrDefaultAsync(q => q.ID == id);
            if (question != null)
            {
                _dbContext.Questions.Remove(question);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Update(int id, Question question)
        {
            Question? oldQuestion = await _dbContext.Questions.FindAsync(id);
            if (oldQuestion != null)
            {
                _dbContext.Update(question);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"Question with ID {id} not found for update.");
            }
        }
    }
}
