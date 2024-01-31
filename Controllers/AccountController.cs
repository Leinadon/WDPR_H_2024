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
    public class LoginModel
    {
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
    }


    [Route("api/identityUser")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)//AANPASSENIdentityUser
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost]
        [Route("registreer")]
        public async Task<ActionResult<IEnumerable<OurUser>>> Registreer([FromBody] GebruikerMetWachwoord gebruikerMetWachwoord)
        {

            var resultaat = await _userManager.CreateAsync(gebruikerMetWachwoord, gebruikerMetWachwoord.Password);

            var user = await _userManager.FindByIdAsync(gebruikerMetWachwoord.Id);
            if (user != null)
            {
                if (!await _userManager.IsInRoleAsync(gebruikerMetWachwoord, "Gebruiker"))
                {
                    await _userManager.AddToRoleAsync(gebruikerMetWachwoord, "Gebruiker");
                }
            }
            return !resultaat.Succeeded ? new BadRequestObjectResult(resultaat) : StatusCode(201);
        }



        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            if (loginModel == null)
            {
                return BadRequest("Invalid request data");
            }

            Console.WriteLine("Start login proces");
            var _user = await _userManager.FindByNameAsync(loginModel.Username);
            var roles = await _userManager.GetRolesAsync(_user);

            if (_user != null && await _userManager.CheckPasswordAsync(_user, loginModel.PasswordHash))
            {
                var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("awef98awef978haweof8g7aw789efhh789awef8h9awh89efh89awe98f89uawef9j8aw89hefawef"));

                var signingCredentials = new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, _user.UserName)
                };


                if (roles == null || !roles.Any())
                {
                    Console.WriteLine("User has no roles assigned");
                    return Unauthorized("User has no roles assigned");
                }
                else
                {
                    Console.WriteLine("There's a role");
                }
                foreach (var role in roles)
                {
                    Console.WriteLine(role);
                    claims.Add(new Claim(ClaimTypes.Role, role));
                
                }

                var tokenOptions = new JwtSecurityToken
                (
                    issuer: "https://localhost:7258",
                    audience: "https://localhost:7258",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(10),
                    signingCredentials: signingCredentials
                );

                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                // Set the token in a cookie
                Response.Cookies.Append("TokenCookie", token, new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.None,
                    Expires = DateTime.Now.AddDays(1)
                });

                return Ok(new { Token = token, Roles = roles, user = _user });
            }

            return Unauthorized("Invalid username or password");
            // return Unauthorized();
        }


        //         [HttpPost("login")]
        //         public async Task<IActionResult> Login(string Username, string passwordHash)
        //         {
        //             var _user = await _userManager.FindByNameAsync(Username);
        //             if (_user != null)
        //                 if (await _userManager.CheckPasswordAsync(_user, passwordHash))
        //                 {
        //                     var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("awef98awef978haweof8g7aw789efhh789awef8h9awh89efh89awe98f89uawef9j8aw89hefawef"));

        //                     var signingCredentials = new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        //                     var claims = new List<Claim> { new Claim(ClaimTypes.Name, _user.UserName) };
        //                     //var roles = await _userManager.GetRolesAsync(_user);
        //                     //foreach (var role in roles)
        //                     //    claims.Add(new Claim(ClaimTypes.Role, role));
        //                     var tokenOptions = new JwtSecurityToken
        //                     (
        //                         issuer: "https://localhost:7258",
        //                         audience: "https://localhost:7258",
        //                         claims: claims,
        //                         expires: DateTime.Now.AddMinutes(10),
        //                         signingCredentials: signingCredentials
        //                     );
        //                     // return Ok(new { Token = new JwtSecurityTokenHandler().WriteToken(tokenOptions) });

        // //----
        //                     var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

        //                     // Set the token in a cookie
        //                     Response.Cookies.Append("TokenCookie", token, new CookieOptions
        //                     {
        //                         HttpOnly = true, // This prevents client-side scripts from accessing the cookie
        //                         Secure = true,   // Ensures that the cookie is only sent over HTTPS if your app is running on HTTPS
        //                         SameSite = SameSiteMode.Strict, // Adjust as needed
        //                         Expires = DateTime.Now.AddDays(1) // Set the expiration time for the cookie
        //                     });

        //                     return Ok(new { Token = token });
        // //----                    
        //                 }

        //             return Unauthorized();
        //         }
    }
}