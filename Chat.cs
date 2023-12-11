using System.Collections.Specialized;
using System.Dynamic;

public class Chat
{
    private static int NextID = 1;
    public int ID {get; private set;}
    private Onderzoek? Onderzoek {get; set;}
    private Gebruiker  Gebruiker1{get; set;}
    private Gebruiker  Gebruiker2{get; set;}
    private DateTime Created{get; set;}
    private DateTime LastUpdated{get; set;}
    private List<Bericht> Berichten = new List<Bericht>();
    public Chat(Onderzoek onderzoek, Bedrijfsaccount bedrijfsaccount, Ervaringsdeskundige ervaringsdeskundige)
    {
        this.Onderzoek = onderzoek;
        this.Gebruiker1 = bedrijfsaccount;
        this.Gebruiker2 = ervaringsdeskundige;
        this.ID = NextID;
        NextID++;
        this.Created = setDateTimeNow();
        this.LastUpdated = setDateTimeNow();

    }
    public Chat(Gebruiker gebruiker1, Gebruiker gebruiker2){
        this.Gebruiker1 = gebruiker1;
        this.Gebruiker2 = gebruiker2;
        this.ID = NextID;
        NextID++;
        this.Created = setDateTimeNow();
        this.LastUpdated = setDateTimeNow();
    }
    private DateTime setDateTimeNow(){
        return DateTime.Now;
    }
    public void NieuwBericht(string inhoud, Gebruiker gebruiker){
        Bericht bericht = new Bericht(gebruiker, this, inhoud);
        Berichten.Add(bericht);
    }    
}