using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace WPR{
    
    [Route("api/signin")]
    [ApiController]
    public class TokenController  : ControllerBase{

        private readonly IUserService _userservice;

        public TokenController(IUserService userService){
            _userservice = userService;
        }

        private string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }
    }
}