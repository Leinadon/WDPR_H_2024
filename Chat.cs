using System.Collections.Specialized;
using System.Dynamic;

public class Chat
{
    private static int NextID = 1;
    public int ID {get; private set;}
    private Onderzoek? Onderzoek;
    private Bedrijfsaccount Bedrijfsaccount;
    private Ervaringsdeskundige Ervaringsdeskundige;
    private DateTime Created;
    private DateTime LastUpdated;
    private List<Bericht> Berichten = new List<Bericht>();
    public Chat(Onderzoek? onderzoek, Bedrijfsaccount bedrijfsaccount, Ervaringsdeskundige ervaringsdeskundige)
    {
        this.Onderzoek = onderzoek;
        this.Bedrijfsaccount = bedrijfsaccount;
        this.Ervaringsdeskundige = ervaringsdeskundige;
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