using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph.Models;
using Microsoft.IdentityModel.Tokens;
namespace WPR
{


    public class GebruikerMetWachwoord : IdentityUser
    {
        public string? Password { get; init; }
    }
    [Route("api/identityUser")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost]
        [Route("registreer")]
        public async Task<ActionResult<IEnumerable<IdentityUser>>> Registreer([FromBody] GebruikerMetWachwoord gebruikerMetWachwoord)
        {
            var resultaat = await _userManager.CreateAsync(gebruikerMetWachwoord, gebruikerMetWachwoord.Password);
            return !resultaat.Succeeded ? new BadRequestObjectResult(resultaat) : StatusCode(201);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(string Username, string passwordHash)
        {
            var _user = await _userManager.FindByNameAsync(Username);
            if (_user != null)
                if (await _userManager.CheckPasswordAsync(_user, passwordHash))
                {
                    var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("awef98awef978haweof8g7aw789efhh789awef8h9awh89efh89awe98f89uawef9j8aw89hefawef"));

                    var signingCredentials = new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
                    var claims = new List<Claim> { new Claim(ClaimTypes.Name, _user.UserName) };
                    //var roles = await _userManager.GetRolesAsync(_user);
                    //foreach (var role in roles)
                    //    claims.Add(new Claim(ClaimTypes.Role, role));
                    var tokenOptions = new JwtSecurityToken
                    (
                        issuer: "https://localhost:7258",
                        audience: "https://localhost:7258",
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(10),
                        signingCredentials: signingCredentials
                    );
                    return Ok(new { Token = new JwtSecurityTokenHandler().WriteToken(tokenOptions) });
                }

            return Unauthorized();
        }
    }
}