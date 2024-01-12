using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
namespace WPR
{
    [Table("User")]
    public class User : IdentityUser
    {
        

        [Required][StringLength(64, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required][StringLength(64, MinimumLength = 2)]
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        [Required][StringLength(15, MinimumLength = 2)]
        public string Phone { get; set; }
        public string Role {get; set;}
        [InverseProperty("User2")]
        public ICollection<Chat> chats2 {get;} = new List<Chat>();
        [InverseProperty("User1")]
        public ICollection<Chat> chats {get;} = new List<Chat>();
        [InverseProperty("Sender")]
        public ICollection<ChatMessage> chatMessages {get;} = new List<ChatMessage>();
    }
}
