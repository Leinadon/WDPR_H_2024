//Class bedrijf heeft alle informatie over een bedrijf die onderzoeken willen uitvoeren via het protaal.
//Bij een bedrijf kunnen verschillende Bedrijfsaccounts horen. Dit zijn de accounts van medewerkers.
public class Bedrijf{
    private static int nextID = 1;
    public int ID {get; private set;}
    public string Naam {get; private set;}
    public string Branche {get; private set;}
    public string Locatie {get; private set;}
    public string Link {get; private set;}
    public string Email {get; private set;}
    public DateTime Created {get; private set}
    public DateTime LastUpdated {get; private set;}
    public List<Bedrijfsaccount> bedrijfsaccounts = new List<Bedrijfsaccount>();
    //constructor
    public Bedrijf(string naam, string branche, string locatie, string link, string email){
        this.Naam = naam;
        this.Branche = branche;
        this.Locatie = locatie;
        this.Link = link;
        this.Email = email;
        this.Created = SetDateTimeNow();
        this.LastUpdated = SetDateTimeNow();
        this.ID = nextID;
        nextID++;
    }
    //Datum en tijd genereren van dit moment.
    public DateTime SetDateTimeNow(){
        return DateTime.Now;
    }
    //Methode om een gebruikersaccount toe te voegen
    public void VoegNieuweAccountToe(Bedrijfsaccount bedrijfsaccount){
        bedrijfsaccounts.Add(bedrijfsaccount);
    }
}