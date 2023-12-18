using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WPR
{
    public abstract class User: IdentityUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PostalCode { get; set; }
    }
}
