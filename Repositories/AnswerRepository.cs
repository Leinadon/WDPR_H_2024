using Microsoft.EntityFrameworkCore;

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
        /// <summary>
        /// Roept alle answers op 
        /// </summary>
        /// <returns></returns>
        public async Task<List<Answer>> Get()
        {
            //alle antwoorden
            return await _dbContext.Answers.ToListAsync();
        }
        /// <summary>
        /// Roept een Answer op met een ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Answer?> GetById(int id)
        {
            return await _dbContext.Answers.FirstOrDefaultAsync(a => a.ID == id);
        }
        /// <summary>
        /// Voegt een Answer toe aan de db
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        public async Task<Answer> Create(Answer answer)
        {
            _dbContext.Answers.Add(answer);
            await _dbContext.SaveChangesAsync();
            return answer;
        }
        /// <summary>
        /// Past een Answer aan in de db 
        /// </summary>
        /// <param name="id">Id van de Answer die je wilt aanpassen</param>
        /// <param name="answer">Answer die het uiteindelijk moet worden</param>
        /// <returns></returns>
        public async Task Update(int id, Answer answer)
        {
            Answer? oldAnswer = await _dbContext.Answers.FindAsync(id);
            if(oldAnswer != null)
            {
                _dbContext.Update(answer);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"Answer with ID {id} not found for update.");
            }
            
        }
        /// <summary>
        /// Verwijderd een Answer uit de db
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
