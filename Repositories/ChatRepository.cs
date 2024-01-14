using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public interface IChatRepository
    {
        Task<List<OurChat>> Get(User user);
        Task<List<OurChat>> GetAll();
        Task<OurChat?> GetById(int id);
        Task<OurChat?> GetByUserId(int id);
        Task<OurChat> Create(OurChat ourChat);
        Task AddMessage(OurChatMessage ourChatMessage, int ChatId);
    }

    public class ChatRepository : IChatRepository
    {
        private readonly WPRDbContext _dbContext;

        public ChatRepository(WPRDbContext dbContext)
        {
            this._dbContext = dbContext;
            
        }
        
        public async Task<List<OurChat>> GetAll()
        {
            return await _dbContext.OurChats
                .ToListAsync();
        }

        /// <summary>
        /// Haalt een lijst met alle chats van een gebruiker op uit de db
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<List<OurChat>> Get(User user)
        {
            return await _dbContext.OurChats
                .Where(c =>  (c.User1 != null  && c.User1.Id == user.Id) || (c.User2 != null && c.User2.Id == user.Id))
                .ToListAsync();
        }
        /// <summary>
        /// Haalt een Chat op met de ID 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<OurChat?> GetById(int id)
        {
            return await _dbContext.OurChats
                .Where(c => c.ID.Equals(id.ToString()))
                .FirstOrDefaultAsync();
        }
        /// <summary>
        /// Create Chat met 2 users verbonden aan een onderzoek
        /// </summary>
        /// <param name="user1"></param>
        /// <param name="user2"></param>
        /// <param name="doesResearch"></param>
        /// <returns></returns>
        public async Task<OurChat> Create(OurChat ourChat)
        {
            _dbContext.OurChats.Add(ourChat);
            await _dbContext.SaveChangesAsync();
            return ourChat;
        }
        /// <summary>
        /// Voegt een chatmessage toe aan de database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="sender"></param>
        /// <returns></returns>
        public async Task AddMessage(OurChatMessage ourChatMessage, int ChatID)
        {
            OurChat? chat = await _dbContext.OurChats.FirstOrDefaultAsync(c => c.ID.Equals(ChatID.ToString()));
            if (chat != null)
            {
                
                chat.Messages.Add(ourChatMessage);
                await _dbContext.SaveChangesAsync();
            }else{
                throw new InvalidOperationException($"Chat with ID {ChatID} can not be found");
            }
        }
        /// <summary>
        /// Pakt een chat uit de db met de id van een user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task<OurChat?> GetByUserId(int id)
        {
            OurChat? chat = await _dbContext.OurChats.FirstOrDefaultAsync(c => (c.User1 != null && c.User1.Id.Equals(id))  || (c.User2 != null && c.User2.Equals(id)));
            if(chat != null){
                return chat;
            }else{
                throw new InvalidOperationException($"Chat with UserID {id} not found.");

            }

        }
    }
}
