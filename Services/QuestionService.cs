using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPR
{
    public interface IQuestionService
    {
        Task<List<Question>> Get();
        Task<Question?> GetById(int id);
        Task<Question?> Create(Question question);
        Task Update(int id, Question question);
        Task Delete(int id);
    }

    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            this._questionRepository = questionRepository;
        }

        public async Task<List<Question>> Get()
        {
            return await _questionRepository.Get();
        }

        public async Task<Question?> GetById(int id)
        {
            return await _questionRepository.GetByID(id);
        }

        public async Task<Question?> Create(Question question)
        {
            return await _questionRepository.Create(question);
        }

        public async Task Delete(int id)
        {
            await _questionRepository.Delete(id);
        }

        public async Task Update(int id, Question question)
        {
            await _questionRepository.Update(id, question);
        }
    }
}
