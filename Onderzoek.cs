using System.Runtime.CompilerServices;

public class Onderzoek{
    public int ID {get; private set;}
    public string Titel{get; set;}
    public string? Beschrijving{get; set;}
    public DateTime OprichtingsDatum{get; set;}
    public string? Locatie{get; set;}
    public string? Beloning{get; set;}
    public string? Status{get; set;}
    public List<Ervaringsdeskundige> Ervaringsdeskundigen = new List<Ervaringsdeskundige>();
    public Bedrijf Bedrijf{get; set;}
    public Boolean Engelstalig{get;set;}

    //Default constructor
    public Onderzoek(){
        this.ID=0;
        this.Titel = "Default voornaam";
        this.Beloning = "Defeault belonging";
        this.Beschrijving = "Default beschrijving";
        this.Locatie = "Default Locatie";
        this.OprichtingsDatum = DateTime.Now;
        this.Bedrijf = new Bedrijf("Default naam", "Default Branche", "Default Locatie", "Default Link", "Default Email");
        this.Engelstalig = false;
    }
    public Onderzoek(string titel, string? beschrijving, string? locatie, string? Beloning, string? status, Bedrijf bedrijf , Boolean Engelstalig)
    {
        this.Titel = titel;
        this.Beschrijving = beschrijving;
        this.Locatie = locatie;
        this.Beloning = Beloning;
        this.Status = status;
        this.Engelstalig = Engelstalig;
        this.OprichtingsDatum = DateTime.Now;
        this.Bedrijf = bedrijf;
        

    }
    public void addNewErvaringsdeskundige(Ervaringsdeskundige ervaringsdeskundige){
        Ervaringsdeskundigen.Add(ervaringsdeskundige);
    }
}