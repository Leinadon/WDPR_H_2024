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
        public async Task<ActionResult<List<Chat>>> Get(User user)
        {
            try{
                List<Chat> chats = await _chatService.Get(user);
                if(chats.Count == 0){
                    return NoContent();
                }
                if(chats != null){
                    return Ok(chats);
                }else{
                    return NotFound();
                }
            }catch(Exception ex){
                return Problem("Probleem bij het opvragen van alle chats van een User");
            }
            
        }
        [HttpGet()]

        // GET api/chats/3
        [HttpGet("{id}")]
        public async Task<ActionResult<Chat>> Get(int id)
        {
            try{
                Chat? chat = await _chatService.GetById(id);
                if(chat != null){
                    return Ok(chat);
                }else{
                    return NotFound();
                }
            }catch(Exception ex){
                return Problem("Probleem bij het opvragen van een chat");
            }
        }


        //TODO Create maken voor een chat die aangemaakt wordt met een onderzoek
        // POST api/chats
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] string userId)
        {
            User loggedInUser = null;

            User? userToChat = await _userService.GetByIDString(userId);

            if (userToChat == null)
            {
                // TODO: throw error -> User not found
            }
            
            Chat createdChat = await _chatService.Create(loggedInUser, userToChat);

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
