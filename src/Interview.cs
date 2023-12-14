public class Interview : Onderzoek{
    public List<Vraag> Vragen = new List<Vraag>();
    public Ervaringsdeskundige Ervaringsdeskundige{get; set;}

    public Interview(string titel, string beschrijving, string locatie, string beloning, string status, Ervaringsdeskundige ervaringsdeskundige){
        this.Titel = titel;
        this.Beschrijving = beschrijving;
        this.Locatie = locatie;
        this.Beloning = beloning;
        this.Status = status;
        this.OprichtingsDatum = DateTime.Now;
        this.Ervaringsdeskundige = ervaringsdeskundige;
    }
    private void VoegVraagToe(string text){
        Vraag vraag = new Vraag(text, this);
        
    }
}