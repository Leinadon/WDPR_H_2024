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
        public async Task<ActionResult<List<OurChat>>> Get(OurUser user)
        {
            try{
                List<OurChat> chats = await _chatService.Get(user);
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
        public async Task<ActionResult<OurChat>> Get(int id)
        {
            try{
                OurChat? chat = await _chatService.GetById(id);
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
        public async Task<IActionResult> Create([FromBody] OurChat OurChat)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return CreatedAtRoute("Get", new { id = OurChat.ID }, await _chatService.Create(OurChat));

            }
            catch (Exception ex)
            {
                return Problem("Problem posting a Company object"); // Logging
            }
        }

        // POST api/chats/3
        [HttpPost("{id}")]
        public async Task SendMessage([FromBody] OurChatMessage ourChatMessage, [FromBody] int ChatID)
        {

            await _chatService.AddMessage(ourChatMessage, ChatID);
        }
    }
}
