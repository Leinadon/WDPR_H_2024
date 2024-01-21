using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WPR
{
    [Table("OurChats")]
    public class OurChat
    {
        
        [Key]
        public int ID { get; private set; }
        
        public string User1ID {get; set;}
        [NotMapped]
        [ForeignKey(nameof(User1ID))]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public OurUser? User1 {get; set;}
        public string User2ID {get; set;}
        [ForeignKey(nameof(User2ID))]
        [InverseProperty(nameof(User2.Chats2))]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        [NotMapped]
        public OurUser? User2 {get; set;}   
        
        public IList<OurChatMessage> Messages { get; }  = new List<OurChatMessage>();
        public OurChatStatus Status { get; set; }
        public DoesResearch? DoesResearch {get; set;}
        


        public OurChat()
        {
            User1ID = string.Empty;
            User2ID = string.Empty;

        }
        
    }
    [Table("OurChatMessages")]
    public class OurChatMessage
    {
        [Key]
        public int OurChatMessageId { get; set; }
        [Required] [StringLength(1024, MinimumLength =2)]
        public string Text { get; set; }

        public DateTime Date { get; } = DateTime.Now;

        public int OurChatID { get; set; }
        
        [ForeignKey(nameof (OurChatID))]
        public OurChat? ourChat { get; set; }

        public string SenderUserId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        [ForeignKey(nameof(SenderUserId))]

        public OurUser? Sender { get; set; }

        public OurChatMessage(){
            Text = string.Empty;
            SenderUserId = string.Empty;

        }

    }

    public enum OurChatStatus
    {
        OPEN,
        CLOSED
    }
}