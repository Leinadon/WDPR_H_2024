public class Interview : Onderzoek{
    private List<Vraag> Vragen = new List<Vraag>();
    private Ervaringsdeskundige Ervaringsdeskundige{get; set;}

    public Interview(string titel, string beschrijving, string locatie, string beloning, string status, Ervaringsdeskundige ervaringsdeskundige){
        this.Titel = titel;
        this.Beschrijving = beschrijving;
        this.Locatie = locatie;
        this.Beloning = beloning;
        this.Status = status;
        this.ID = GetNextID();
        this.Created = setDateTimeNow();
        this.LastUpdated = setDateTimeNow();
        this.OprichtingsDatum = setDateTimeNow();
        this.Ervaringsdeskundige = ervaringsdeskundige;
    }
    private void VoegVraagToe(string text){
        Vraag vraag = new Vraag(text, this);
        
    }
}