using System.Linq.Expressions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;

namespace WPR{

    [Authorize]
    public class AccountController : ControllerBase
    {
        
        [AllowAnonymous]
        public IActionResult SignIn()
        {
            //TODO deze class moet beter
            try{
                var redirectUrl = Url.Action(nameof(HomeController.Index), "Home");
                return Challenge(new AuthenticationProperties { RedirectUri = redirectUrl });
            }catch{
                return Problem();
            }
            
            
        }

        public new async Task<IActionResult> SignOut()
        {
            try{
                if(User.Identity != null){
                    if(User.Identity.IsAuthenticated){
                        var callbackUrl = Url.Action(nameof(SignedOut), "Account", values: null, protocol: Request.Scheme);
                        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                        return Ok();
                    }
                    return Unauthorized();
                }
                return NoContent();
            }catch{
                return Problem("Er is een probleem opgetreden bij het uitloggen van een gebruiker");
            }
        }

        public IActionResult SignedOut()
        {
            try{
                if(User.Identity != null){
                    if (User.Identity.IsAuthenticated)
                    {
                        // Redirect to home page if the user is authenticated.
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                    }
                    return NoContent();
                }
                return Unauthorized();
            } catch{
                return Problem("Er is een probleem opgetreden bij het Redirecten na het uilogge van een gebruiker");
            }
        }
    }
}