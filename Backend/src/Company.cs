//Class bedrijf heeft alle informatie over een bedrijf die onderzoeken willen uitvoeren via het protaal.
//Bij een bedrijf kunnen verschillende Bedrijfsaccounts horen. Dit zijn de accounts van medewerkers.
public class Company{
    public int ID {get; private set;}
    public string Name {get; set;}
    public string Branche {get; set;}
    public string Location {get; set;}
    public string Link {get; set;}
    public string Email {get; set;}
    public List<CompanyAccount> CompanyAccounts = new List<CompanyAccount>();
    //constructor
    public Company(string name, string branche, string location, string link, string email){
        this.Name = name;
        this.Branche = branche;
        this.Location = location;
        this.Link = link;
        this.Email = email;
    }
    //Methode om een gebruikersaccount toe te voegen
    public void AddNewAccount(CompanyAccount bedrijfsaccount){
        CompanyAccounts.Add(bedrijfsaccount);
    }
}