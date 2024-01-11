using System.Security.Claims;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace WPR{
    [Route("api/profile")]
    [ApiController]

    public class ProfileController : ControllerBase
    {
        private readonly IUserService _userService;

        public ProfileController(IUserService userService){
            _userService = userService;
        }

        // GET: api/profile
        [HttpGet]
        public async Task<IActionResult> UserProfile(){
            var LoggedUser = HttpContext.User;
            if(LoggedUser.Identity != null){
                if(LoggedUser.Identity.IsAuthenticated){
                    User? user = await _userService.GetByEmail(LoggedUser.Claims.FirstOrDefault(u => u.Type == ClaimTypes.Email)?.Value);
                    if(user != null){
                        return Ok(user);
                    }else{
                        return NotFound();
                    }
                }else{
                    return Unauthorized();
                }
            }else{
                return NotFound();
            }  
        }
    }
}