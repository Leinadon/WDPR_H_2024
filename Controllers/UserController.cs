using Microsoft.AspNetCore.Mvc;


namespace WPR
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: api/users
        [HttpGet]
        public async Task<List<User>> Get()
        {
            List<User> users = await _userRepository.Get();
            return users;
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            User users = await _userRepository.GetById(id);
            return users;
        }

    }
}
