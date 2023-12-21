using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public interface IChatRepository
    {
        Task<List<Chat>> Get(User user);
        Task<Chat?> GetById(int id, User user);
        Task<Chat> Create(List<User> users);
        Task AddMessage(int id, string text, User sender);
    }

    public class ChatRepository : IChatRepository
    {
        private readonly WPRDbContext _dbContext;

        public ChatRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Chat>> Get(User user)
        {
            return await _dbContext.Chats
                .Where(c => c.Users.Any(u => u.Id == user.Id))
                .ToListAsync();
        }

        public async Task<Chat?> GetById(int id, User user)
        {
            return await _dbContext.Chats
                .Where(c => c.ChatId == id)
                .Where(c => c.Users.Any(u => u.Id == user.Id))
                .FirstOrDefaultAsync();
        }

        public async Task<Chat> Create(List<User> users)
        {
            Chat chat = new Chat(users);

            _dbContext.Chats.Add(chat);

            await _dbContext.SaveChangesAsync();

            return chat;
        }

        public async Task AddMessage(int id, string text, User sender)
        {
            Chat? chat = await _dbContext.Chats.FirstOrDefaultAsync(c => c.ChatId == id);

            if (chat == null)
            {
                // TODO: handle error -> chat not found
                return;
            }

            ChatMessage chatMessage = new ChatMessage(chat.ChatId, text, sender);

            chat.Messages.Add(chatMessage);

            await _dbContext.SaveChangesAsync();
        }
    }
}
