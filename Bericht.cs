using System.Dynamic;

public class Bericht{
    private static int NextId = 1;
    public int ID{get; private set;}
    public Gebruiker Gebruiker {get; set;}
    public Chat chat{get; set;}
    public string Inhoud {get; set;}
    public Bericht(Gebruiker gebruiker, Chat chat, String inhoud)
    {
        this.Gebruiker = gebruiker;
        this.chat = chat;
        this.Inhoud = inhoud;
        this.ID= NextId;
        NextId++;
    }
}