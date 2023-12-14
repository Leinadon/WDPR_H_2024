using System.Reflection;

public class Vragenlijst : Onderzoek{
    public List<Vraag> Vragen = new List<Vraag>();
     
    public Vragenlijst(string titel, string? beschrijving, string? locatie, string? beloning, string status, Bedrijf bedrijf)
    {
        this.Titel = titel;
        this.Beschrijving = beschrijving;
        this.Locatie = locatie;
        this.Beloning = beloning;
        this.Status = status;
        this.Bedrijf = bedrijf;
    }
    private void VoegVraagToe(string text){
        Vraag vraag = new Vraag(text, this);
        Vragen.Add(vraag);
    }
}