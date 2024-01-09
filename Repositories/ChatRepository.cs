using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public interface IChatRepository
    {
        Task<List<Chat>> Get(User user);
        Task<Chat?> GetById(int id);
        Task<Chat> Create(User user1, User user2);
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

        /// <summary>
        /// Haalt een lijst met alle chats van een gebruiker op uit de db
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<List<Chat>> Get(User user)
        {
            return await _dbContext.Chats
                .Where(c => c.user1.Id == user.Id || c.user2.Id == user.Id)
                .ToListAsync();
        }
        /// <summary>
        /// Haalt een Chat op met de ID 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<Chat?> GetById(int id)
        {
            return await _dbContext.Chats
                .Where(c => c.ChatId == id)
                .FirstOrDefaultAsync();
        }
        /// <summary>
        /// Create Chat met 2 users verbonden aan een onderzoek
        /// </summary>
        /// <param name="user1"></param>
        /// <param name="user2"></param>
        /// <param name="doesResearch"></param>
        /// <returns></returns>
        public async Task<Chat> Create(User user1, User user2, DoesResearch doesResearch)
        {
            Chat chat = new Chat(user1, user2, doesResearch);
            _dbContext.Chats.Add(chat);
            await _dbContext.SaveChangesAsync();
            return chat;
        }
        /// <summary>
        /// Create Chat met 2 users
        /// </summary>
        /// <param name="user1"></param>
        /// <param name="user2"></param>
        /// <returns></returns>
        public async Task<Chat> Create(User user1, User user2)
        {
            Chat chat = new Chat(user1, user2);
            _dbContext.Chats.Add(chat);
            await _dbContext.SaveChangesAsync();
            return chat;
        }
        /// <summary>
        /// Voegt een chatmessage toe aan de database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="sender"></param>
        /// <returns></returns>
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
