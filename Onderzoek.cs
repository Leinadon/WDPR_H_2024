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
    public Bedrijfsaccount Bedrijfsaccount{get; set;}
    public Boolean Engelstalig{get;set;}

    //Default constructor
    public Onderzoek(){
        this.ID=0;
        this.Titel = "Default voornaam";
        this.Beloning = "Defeault belonging";
        this.Beschrijving = "Default beschrijving";
        this.Locatie = "Default Locatie";
        this.OprichtingsDatum = DateTime.now();
        this.Bedrijfsaccount = new Bedrijfsaccount("default voornaam", "default achternaam", "default postcode", "defail email", null, "default rol", "default functie", false,null);
        this.Engelstalig = false;
    }
    public Onderzoek(string titel, string? beschrijving, string? locatie, string? Beloning, string? status, Bedrijfsaccount bedrijfsaccount, Boolean Engelstalig)
    {
        this.Titel = titel;
        this.Beschrijving = beschrijving;
        this.Locatie = locatie;
        this.Beloning = Beloning;
        this.Status = status;
        this.Engelstalig = Engelstalig;
        this.OprichtingsDatum = DateTime.now();
        this.Bedrijfsaccount = bedrijfsaccount;
        

    }
    public void addNewErvaringsdeskundige(Ervaringsdeskundige ervaringsdeskundige){
        Ervaringsdeskundigen.Add(ervaringsdeskundige);
    }
}