using System.Collections.Specialized;
using System.Dynamic;

public class Chat
{
    public int ID {get; private set;}
    public Research? Research {get; set;}
    public User User1{get; set;}
    public User User2{get; set;}
    public List<Message> Messages = new List<Message>();
    public Chat(Research research, CompanyAccount companyAccount, Specialist specialist)
    {
        this.Research = research;
        this.User1 = companyAccount;
        this.User2 = specialist;
    }
    public Chat(User user1, User user2){
        this.User1 = user1;
        this.User2 = user2;
    }
    public void NewMessage(string inhoud, User user){
        Message message = new Message(user, this, inhoud);
        Messages.Add(message);
    }    
}