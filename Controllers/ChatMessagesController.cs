using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WPR
{
    [Route("api/ChatMessages")]
    [ApiController]
    public class ChatMessagesController : ControllerBase
    {
        private readonly IChatService _chatService;
        private readonly IUserService _userService;
        private readonly ILogger<ChatController> _logger;

        public ChatMessagesController(IChatService chatService, IUserService userService, ILogger<ChatController> logger)
        {
            _chatService = chatService;
            _userService = userService;
            _logger = logger;
        }
        // GET: api/chats
        [HttpGet("/chat/id")]
        public async Task<ActionResult<List<OurChatMessage>>> GetChatMessagesByChat(int id)
        {
            try{
                List<OurChatMessage> ChatMessages = await _chatService.GetMessagesByChat(id);
                if(ChatMessages == null)
                {
                    return NotFound(ChatMessages);
                }
                return Ok(ChatMessages);
            }catch(Exception ex){
                _logger.LogError(ex, "Fout bij het ophalen van chats, GET: api/chats");
                return Problem("Probleem bij het opvragen van alle chats");
            }

        }
    }
}
