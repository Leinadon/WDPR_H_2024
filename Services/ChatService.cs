using WPR;

public interface IChatService
{
    Task<List<OurChat>> Get(OurUser user);
    Task<OurChat?> GetById(int id);
    Task<OurChat> Create(OurChat ourChat);
    Task AddMessage(OurChatMessage ourChatMessage, int ChatId);
}

public class ChatService : IChatService
{
    private readonly IChatRepository _chatRepository;

    public ChatService(IChatRepository chatRepository)
    {
        _chatRepository = chatRepository;
    }

    public async Task<List<OurChat>> Get(OurUser user)
    {

        return await _chatRepository.Get(user);
    }

    public async Task<OurChat?> GetById(int id)
    {
        return await _chatRepository.GetById(id);
    }
    public async Task<OurChat> Create(OurChat ourChat)
    {
        return await _chatRepository.Create(ourChat);
    }

    public async Task AddMessage(OurChatMessage ourChatMessage, int ChatID)
    {
        await _chatRepository.AddMessage(ourChatMessage, ChatID);
    }
}
