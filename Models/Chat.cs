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
        public int user1ID {get; set;}
        [ForeignKey(nameof(user1ID))]
        public User user1 {get; set;}
        public int user2ID {get; set;}
        [ForeignKey(nameof(user2ID))]
        public User user2 {get; set;}
        
        [InverseProperty("Chat")]
        public ICollection<ChatMessage> Messages { get; } = new List<ChatMessage>();
        public ChatStatus Status { get; set; } = ChatStatus.OPEN;
        public int DoesResearchInt {get; set;}
        [ForeignKey(nameof(DoesResearchInt))]
        public DoesResearch? doesResearch {get; set;}
        


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
        
        [ForeignKey(nameof(ChatId))]
        public virtual Chat Chat { get; set; }

        public string SenderUserId { get; set; }
        [ForeignKey(nameof(SenderUserId))]

        public virtual User Sender { get; set; }

        public ChatMessage(Chat chat, string text, User sender) {
            this.Chat = chat;
            this.Text = text;
            this.Sender = sender;
        }

    }

    public enum ChatStatus
    {
        OPEN,
        CLOSED
    }
}