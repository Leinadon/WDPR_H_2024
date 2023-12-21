using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    public class Chat
    {
        [Key]
        public int ChatId { get; private set; }

        public ICollection<User> Users { get; } = new List<User>();

        public ICollection<ChatMessage> Messages { get; } = new List<ChatMessage>();

        public ChatStatus Status { get; set; }

        private Chat() { }

        public Chat(List<User> users)
        {
            this.Users = new List<User>(users);
            this.Status = ChatStatus.OPEN;
        }
    }

    public class ChatMessage
    {
        [Key]
        public int ChatMessageId { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; } = DateTime.Now;

        public int ChatId { get; set; }

        [ForeignKey("ChatId")]
        public virtual Chat Chat { get; set; }

        public string SenderUserId { get; set; }

        [ForeignKey("SenderUserId")]
        public virtual User Sender { get; set; }

        private ChatMessage() { }

        public ChatMessage(int chatId, string text, User sender)
        {
            this.ChatId = chatId;
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