using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public interface IChatRepository
    {
        Task<List<Chat>> Get(User user);
        Task<Chat?> GetById(int id, User user);
        //Onderstaande methode is voor een chat die geopend wordt door 2 users
        Task<Chat> Create(User user1, User user2);
        //Onderstaande methode is voor een chat die geopend wordt bij een onderzoek dat gedaan wordt
        Task<Chat> Create(User user1, User user2, DoesResearch doesResearch);
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
                //.Where(c => c.Users.Any(u => u.UserId == user.UserId))
                .ToListAsync();
        }

        public async Task<Chat?> GetById(int id, User user)
        {
            return await _dbContext.Chats
                .Where(c => c.ChatId == id)
                // .Where(c => c.Users.Any(u => u.UserId == user.UserId))
                .FirstOrDefaultAsync();
        }

        public async Task<Chat> Create(User user1, User user2, DoesResearch doesResearch)
        {
            Chat chat = new Chat(user1, user2, doesResearch);
            _dbContext.Chats.Add(chat);
            await _dbContext.SaveChangesAsync();
            return chat;
        }
        public async Task<Chat> Create(User user1, User user2)
        {
            Chat chat = new Chat(user1, user2);
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

            ChatMessage chatMessage = new ChatMessage(chat, text, sender);

            chat.Messages.Add(chatMessage);

            await _dbContext.SaveChangesAsync();
        }
    }
}
