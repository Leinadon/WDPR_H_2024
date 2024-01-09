using WPR;

public interface IAnswerService
{
    Task<List<Answer>> Get();
    Task<Answer?> GetById(int id);
    Task<Answer> Create(Answer answer);

}

public class AnswerService : IAnswerService
{
    private readonly IAnswerRepository _AnswerRepository;

    public AnswerService(IAnswerRepository AnswerRepository)
    {
        _AnswerRepository = AnswerRepository;
    }

    public async Task<List<Answer>> Get()
    {

        return await _AnswerRepository.Get();
    }

    public async Task<Answer?> GetById(int id)
    {
        return await _AnswerRepository.GetById(id);
    }

    public async Task<Answer> Create(Answer answer)
    {
        return await _AnswerRepository.Create(answer);
    }
}
