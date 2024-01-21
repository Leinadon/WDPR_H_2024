using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace WPR
{
    public class User : IdentityUser
    {
        
        [Required][StringLength(64, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required][StringLength(64, MinimumLength = 2)]
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        [Required][StringLength(15, MinimumLength = 2)]
        public string Phone { get; set; }
        [Required]
        public string idenitityUserId{get;set;}
        public string Role {get; set;}
        [InverseProperty(nameof(OurChat.User2))]
        public ICollection<OurChat>? Chats2 {get;}
        public ICollection<OurChat>? Chats {get;}
        public ICollection<OurChatMessage>? ChatMessages {get;}

        public User(){
            FirstName = string.Empty;
            LastName = string.Empty;
            Phone = string.Empty;
            Role = string.Empty;
        }
    }
}
