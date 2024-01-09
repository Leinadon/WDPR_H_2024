using WPR;

public interface IChatService
{
    Task<List<Chat>> Get(User user);
    Task<Chat?> GetById(int id, User user);
    Task<Chat> Create(User user1, User user2);
    Task<Chat> Create(User user1, User user2, DoesResearch doesResearch);
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

    public async Task<Chat> Create(User user1, User user2)
    {
        return await _chatRepository.Create(user1, user2);
    }
    public async Task<Chat> Create(User user1, User user2, DoesResearch doesResearch)
    {
        return await _chatRepository.Create(user1, user2, doesResearch);
    }

    public async Task AddMessage(int id, string text, User sender)
    {
        await _chatRepository.AddMessage(id, text, sender);
    }
}
