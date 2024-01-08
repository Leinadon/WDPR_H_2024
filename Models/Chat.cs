using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("Chats")]
    public class Chat
    {
        [Key]
        public int ChatId { get; private set; }
        
        public User user1 {get; set;}
        public User user2 {get; set;}

        public ICollection<ChatMessage> Messages { get; } = new List<ChatMessage>();
        [Required]
        public ChatStatus Status { get; set; }
        public DoesResearch doesResearch {get;}


        public Chat()
        {
            this.Status = ChatStatus.OPEN;
        }
    }
    [Table("ChatMessages")]
    public class ChatMessage
    {
        [Key]
        public int ChatMessageId { get; private set; }
        [Required] [StringLength(1024, MinimumLength =2)]
        public string Text { get; set; }

        public DateTime Date { get; } = DateTime.Now;

        public int ChatId { get; set; }

        public virtual Chat Chat { get; set; }

        public string SenderUserId { get; set; }

        public virtual User Sender { get; set; }

        public ChatMessage() { }

    }

    public enum ChatStatus
    {
        OPEN,
        CLOSED
    }
}