using System.Reflection.Metadata;

public class OnlineOpdracht : Onderzoek{
    public string Link{get; set;}
    public string Uitleg{get; set;}
    public List<OnlineOpdrachtResultaat> OnlineOpdrachtResultaten = new List<OnlineOpdrachtResultaat>();
    public OnlineOpdracht(string titel, string beschrijving, string locatie, string beloning, string status,string link, string uitleg){
        this.Link = link;
        this.Uitleg = uitleg;
        this.Titel = titel;
        this.Beschrijving = beschrijving;
        this.Locatie = locatie;
        this.Beloning = beloning;
        this.Status = status;
        this.ID = GetNextID();
        this.OprichtingsDatum = setDateTimeNow();
        this.Created = setDateTimeNow();
        this.LastUpdated = setDateTimeNow();

    }

    private void NieuwResultaat(string opmerking, Ervaringsdeskundige ervaringsdeskundige){
        OnlineOpdrachtResultaat resultaat = new OnlineOpdrachtResultaat(opmerking, ervaringsdeskundige, this);
        OnlineOpdrachtResultaten.Add(resultaat);

    }
}