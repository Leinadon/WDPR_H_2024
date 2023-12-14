using System.Collections.Specialized;
using System.Dynamic;

public class Chat
{
    public int ID {get; private set;}
    public Onderzoek? Onderzoek {get; set;}
    public Gebruiker  Gebruiker1{get; set;}
    public Gebruiker  Gebruiker2{get; set;}
    public List<Bericht> Berichten = new List<Bericht>();
    public Chat(Onderzoek onderzoek, Bedrijfsaccount bedrijfsaccount, Ervaringsdeskundige ervaringsdeskundige)
    {
        this.Onderzoek = onderzoek;
        this.Gebruiker1 = bedrijfsaccount;
        this.Gebruiker2 = ervaringsdeskundige;
    }
    public Chat(Gebruiker gebruiker1, Gebruiker gebruiker2){
        this.Gebruiker1 = gebruiker1;
        this.Gebruiker2 = gebruiker2;
    }
    public void NieuwBericht(string inhoud, Gebruiker gebruiker){
        Bericht bericht = new Bericht(gebruiker, this, inhoud);
        Berichten.Add(bericht);
    }    
}