using Microsoft.AspNetCore.Mvc;


namespace WPR
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/users
        [HttpGet]
        // TODO: check user == admin
        public async Task<List<User>> Get()
        {
            List<User> users = await _userService.Get();
            return users;
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<User> Get(string id)
        {
            // TODO: if user != admin, use GetById(id, userId);

            User? users = await _userService.GetById(id);

            return users;
        }

    }
}
