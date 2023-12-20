using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WPR
{
    [Route("api/chats")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;
        private readonly IUserService _userService;

        public ChatController(IChatService chatService, IUserService userService)
        {
            _chatService = chatService;
            _userService = userService;
        }

        // GET: api/chats
        [HttpGet]
        public async Task<List<Chat>> Get()
        {
            // TODO: get user from cookie

            User loggedInUser = null;

            List<Chat> chats = await _chatService.Get(loggedInUser);

            return chats;
        }

        // GET api/chats/3
        [HttpGet("{id}")]
        public async Task<Chat?> Get(int id)
        {
            User loggedInUser = null;

            Chat? chat = await _chatService.GetById(id, loggedInUser);

            return chat;
        }

        // POST api/chats
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] int userId)
        {
            User loggedInUser = null;

            User userToChat = await _userService.GetById(userId);

            Chat createdChat = await _chatService.Create(new() { loggedInUser, userToChat });

            return Ok(createdChat.ChatId);
        }

        // POST api/chats/3
        [HttpPost("{id}")]
        public async Task SendMessage(int id, [FromBody] string text)
        {
            User loggedInUser = null;

            await _chatService.AddMessage(id, text, loggedInUser);
        }
    }
}
