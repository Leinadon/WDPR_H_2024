using System.ComponentModel.DataAnnotations;
namespace WPR

{
    public class ResetPasswordRequest
    {
        [Required] 
        public string Email {get; set;} = string.Empty;
        [Required] 
        public string Password{get; set;} = string.Empty;
        [Required, Compare("Password")] 
        public string ConfirmPassword {get; set;} = string.Empty;

    }
}
   