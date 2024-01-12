using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.Graph.Models;
namespace WPR
{
    [Table("OurUsers")]
    public class OurUser : IdentityUser
    {

        [Required][StringLength(64, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required][StringLength(64, MinimumLength = 2)]
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        [Required][StringLength(15, MinimumLength = 2)]
        public string Phone { get; set; }
        public string Role {get; set;}
        public ICollection<OurChat> Chats2 {get;}
        public ICollection<OurChat> Chats {get;}
        public ICollection<OurChatMessage> ChatMessages {get;}
    }
}
