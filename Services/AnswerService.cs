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
    /// <summary>
    /// Roept alle answers op die verbonden zitten aan een vraag
    /// </summary>
    /// <param name="question"></param>
    /// <returns></returns>
    public async Task<List<Answer>> Get(Question question)
    {
        return await _AnswerRepository.Get(question);
    }
    /// <summary>
    /// Roept alle answers op die verbonden zitten aan een DoesResearch
    /// </summary>
    /// <param name="doesResearch"></param>
    /// <returns></returns>
    public async Task<List<Answer>> Get(DoesResearch doesResearch)
    {

        return await _AnswerRepository.Get(doesResearch);
    }
    /// <summary>
    /// Roept alle answers op die verbonden zitten aan een user 
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public async Task<List<Answer>> Get(User user)
    {
        return await _AnswerRepository.Get(user);
    }

    public async Task<List<Answer>> Get()
    {

        return await _AnswerRepository.Get();
    }
    /// <summary>
    /// Roept een vraag met een ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<Answer?> GetById(int id)
    {
        return await _AnswerRepository.GetById(id);
    }

    public async Task<Answer> Create(Answer answer)
    {
        return await _AnswerRepository.Create(answer);
    }
}
