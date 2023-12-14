//Class bedrijf heeft alle informatie over een bedrijf die onderzoeken willen uitvoeren via het protaal.
//Bij een bedrijf kunnen verschillende Bedrijfsaccounts horen. Dit zijn de accounts van medewerkers.
public class Bedrijf{
    public int ID {get; private set;}
    public string Naam {get; set;}
    public string Branche {get; set;}
    public string Locatie {get; set;}
    public string Link {get; set;}
    public string Email {get; set;}
    public List<Bedrijfsaccount> bedrijfsaccounts = new List<Bedrijfsaccount>();
    //constructor
    public Bedrijf(string naam, string branche, string locatie, string link, string email){
        this.Naam = naam;
        this.Branche = branche;
        this.Locatie = locatie;
        this.Link = link;
        this.Email = email;
    }
    //Methode om een gebruikersaccount toe te voegen
    public void VoegNieuweAccountToe(Bedrijfsaccount bedrijfsaccount){
        bedrijfsaccounts.Add(bedrijfsaccount);
    }
}