using WPR;

public interface IChatService
{
    Task<List<OurChat>> GetAllFromUser(string user);
    Task<List<OurChat>> GetAll();
    Task<OurChat?> GetById(int id);
    Task<OurChat> Create(OurChat ourChat);
    Task AddMessage(OurChatMessage ourChatMessage, int ChatId);
    Task<List<OurChatMessage>> GetMessagesByChat(int id);
}

public class ChatService : IChatService
{
    private readonly IChatRepository _chatRepository;

    public ChatService(IChatRepository chatRepository)
    {
        _chatRepository = chatRepository;
    }
    public async Task<List<OurChat>> GetAll(){
        return await _chatRepository.GetAll();
    }

    public async Task<List<OurChat>> GetAllFromUser(string user)
    {

        return await _chatRepository.GetAllFromUser(user);
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
    public async Task<List<OurChatMessage>> GetMessagesByChat(int id){
        return await _chatRepository.GetChatMessagesByChat(id);
    }
}
