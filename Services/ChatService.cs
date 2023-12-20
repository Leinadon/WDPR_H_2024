using WPR;

public interface IChatService
{
    Task<List<Chat>> Get(User user);
    Task<Chat?> GetById(int id, User user);
    Task<Chat> Create(List<User> users);
    Task AddMessage(int id, string text, User sender);
}

public class ChatService : IChatService
{
    private readonly IChatRepository _chatRepository;

    public ChatService(IChatRepository chatRepository)
    {
        _chatRepository = chatRepository;
    }

    public async Task<List<Chat>> Get(User user)
    {

        return await _chatRepository.Get(user);
    }

    public async Task<Chat?> GetById(int id, User user)
    {
        return await _chatRepository.GetById(id, user);
    }

    public async Task<Chat> Create(List<User> users)
    {
        return await _chatRepository.Create(users);
    }

    public async Task AddMessage(int id, string text, User sender)
    {
        await _chatRepository.AddMessage(id, text, sender);
    }
}
