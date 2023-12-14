using System.Dynamic;

public class Message{
    public int ID{get; private set;}
    public User User {get; set;}
    public Chat Chat{get; set;}
    public string Inhoud {get; set;}
    public Message(User user, Chat chat, String inhoud)
    {
        this.User = user;
        this.Chat = chat;
        this.Inhoud = inhoud;
    }
}