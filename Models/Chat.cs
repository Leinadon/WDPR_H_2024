using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace WPR
{
    [Table("OurChats")]
    public class OurChat
    {
        
        [Key]
        public int ID { get; private set; }
        public int User1ID {get; set;}
        [ForeignKey(nameof(User1ID))]
        public OurUser User1 {get; set;}
        public int User2ID {get; set;}
        [ForeignKey(nameof(User2ID))]
        [InverseProperty(nameof(User2.Chats2))]
        public OurUser User2 {get; set;}   
        
        public IList<OurChatMessage> Messages { get; }  = new List<OurChatMessage>();
        public OurChatStatus Status { get; set; }
        public DoesResearch? DoesResearch {get; set;}
        


        public OurChat()
        {
            
            this.Status = OurChatStatus.OPEN;
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
        public OurChat ourChat { get; set; }

        public string SenderUserId { get; set; }
        [ForeignKey(nameof(OurUser.Id))]

        public OurUser Sender { get; set; }

    }

    public enum OurChatStatus
    {
        OPEN,
        CLOSED
    }
}