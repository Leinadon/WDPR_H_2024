using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

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
        public ChatStatus Status { get; set; } = ChatStatus.OPEN;
        
        public DoesResearch? doesResearch {get;}


        public Chat(User user1, User user2)
        {
            this.user1 = user1;
            this.user2 = user2;
            this.Status = ChatStatus.OPEN;
        }
        public Chat(User user1, User user2, DoesResearch doesResearch)
        {
            this.user1 = user1;
            this.user2 = user2;
            this.doesResearch = doesResearch;
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

        public ChatMessage(Chat chat, String text, User user) {
            this.Chat = chat;
            this.ChatId = chat.ChatId;
            this.Text = text;
            this.Sender = user;
            this.SenderUserId = user.Id;
        
        }

    }

    public enum ChatStatus
    {
        OPEN,
        CLOSED
    }
}