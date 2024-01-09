using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WPR
{
    public interface IAnswerRepository
    {
        Task<List<Answer>> Get();
        Task<Answer?> GetById(int id);
        Task<Answer> Create(Answer answer);
        Task Update(int id, Answer answer);
        Task Delete(int id);
    }

    public class AnswerRepository : IAnswerRepository
    {
        private readonly WPRDbContext _dbContext;

        public AnswerRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Answer>> Get()
        {
            return await _dbContext.Answers.ToListAsync();
        }

        public async Task<Answer?> GetById(int id)
        {
            return await _dbContext.Answers.FirstOrDefaultAsync(a => a.ID == id);
        }

        public async Task<Answer> Create(Answer answer)
        {
            _dbContext.Answers.Add(answer);
            await _dbContext.SaveChangesAsync();
            return answer;
        }

        public async Task Update(int id, Answer answer)
        {
            _dbContext.Update(answer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Answer? answer = await _dbContext.Answers.FirstOrDefaultAsync(a => a.ID == id);

            if (answer != null)
            {
                _dbContext.Answers.Remove(answer);
                await _dbContext.SaveChangesAsync();
            }
            // Handle the case when the answer with the specified id is not found.
        }
    }
}
