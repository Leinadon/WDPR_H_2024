using Microsoft.AspNetCore.Identity;
namespace WPR
{
    public class User : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        // public string Email: Already in IdentityUser
        public DateOnly BirthDate { get; set; }
        public string Phone { get; set; }
    }
}
