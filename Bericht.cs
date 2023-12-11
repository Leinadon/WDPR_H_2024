using System.Dynamic;

public class Bericht{
    private static int NextId = 1;
    public int ID{get; private set;}
    private Gebruiker Gebruiker {get; set;}
    private DateTime Created {get; set;}
    private DateTime LastUpdate {get; set;}
    private Chat chat{get; set;}
    private string Inhoud {get; set;}
    public Bericht(Gebruiker gebruiker, Chat chat, String inhoud)
    {
        this.Gebruiker = gebruiker;
        this.chat = chat;
        this.Inhoud = inhoud;
        this.ID= NextId;
        NextId++;
        this.Created = setDateTimeNow();
        this.LastUpdate = setDateTimeNow();
    }
    private DateTime setDateTimeNow(){
        return DateTime.Now;
    } 
}