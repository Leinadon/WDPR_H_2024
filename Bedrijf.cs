//Class bedrijf heeft alle informatie over een bedrijf die onderzoeken willen uitvoeren via het protaal.
//Bij een bedrijf kunnen verschillende Bedrijfsaccounts horen. Dit zijn de accounts van medewerkers.
public class Bedrijf{
    private static int nextID = 1;
    public int ID {get; private set;}
    private string Naam {get;set;}
    private string Branche {get;set;}
    private string Locatie {get;set;}
    private string Link {get;set;}
    private string Email {get;set;}
    private DateTime Created {get;}
    private DateTime LastUpdated {get;set;}
    private List<Bedrijfsaccount> bedrijfsaccounts = new List<Bedrijfsaccount>();
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
    private DateTime SetDateTimeNow(){
        return DateTime.Now;
    }

    private void VoegNieuweAccountToe(){
        
    }
}