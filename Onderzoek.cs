using System.Runtime.CompilerServices;

public class Onderzoek{
    private static int CurrtentID;
    public int ID {get; protected set;}
    protected string Titel{get; set;}
    protected string? Beschrijving{get; set;}
    protected DateTime OprichtingsDatum{get; set;}
    protected string? Locatie{get; set;}
    protected string? Beloning{get; set;}
    protected string? Status{get; set;}
    protected DateTime Created{get; set;}
    protected DateTime LastUpdated{get; set;}
    protected List<Ervaringsdeskundige> Ervaringsdeskundigen = new List<Ervaringsdeskundige>();
    protected Bedrijfsaccount Bedrijfsaccount{get; set;}
    protected Boolean Engelstalig{get;set;}

    //Default constructor
    public Onderzoek(){
        this.ID=0;
        this.Titel = "Default voornaam";
        this.Beloning = "Defeault belonging";
        this.Beschrijving = "Default beschrijving";
        this.Locatie = "Default Locatie";
        this.OprichtingsDatum = setDateTimeNow();
        this.Created = setDateTimeNow();
        this.LastUpdated = setDateTimeNow();
        this.Bedrijfsaccount = new Bedrijfsaccount("default voornaam", "default achternaam", "default postcode", "defail email", null, "default rol", "default functie", false,null);
        this.Engelstalig = false;
    }
    static Onderzoek() => CurrtentID = 0;
    public Onderzoek(string titel, string? beschrijving, string? locatie, string? Beloning, string? status, Bedrijfsaccount bedrijfsaccount, Boolean Engelstalig)
    {
        this.Titel = titel;
        this.Beschrijving = beschrijving;
        this.Locatie = locatie;
        this.Beloning = Beloning;
        this.Status = status;
        this.ID = CurrtentID;
        this.Engelstalig = Engelstalig;
        CurrtentID++;
        Created = setDateTimeNow();
        LastUpdated = setDateTimeNow();
        OprichtingsDatum = setDateTimeNow();
        this.Bedrijfsaccount = bedrijfsaccount;
        

    }
    //Methoide om de volgende ID te krijgen
    protected int GetNextID() => CurrtentID++;
    //methode die de datum en tijd genereert
    protected DateTime setDateTimeNow(){
        return DateTime.Now;
    } 
    public void addNewErvaringsdeskundige(Ervaringsdeskundige ervaringsdeskundige){
        Ervaringsdeskundigen.Add(ervaringsdeskundige);
    }
}