//Class bedrijf heeft alle informatie over een bedrijf die onderzoeken willen uitvoeren via het protaal.
//Bij een bedrijf kunnen verschillende Bedrijfsaccounts horen. Dit zijn de accounts van medewerkers.
public class Company{
    public int ID {get; private set;}
    public string Name {get; set;}
    public string Branche {get; set;}
    public string Location {get; set;}
    public string WebsiteURL {get; set;}
    public string ContactEmail {get; set;}
    public string TrackingID { get; set; }  
    public List<Employee> CompanyAccounts = new List<Employee>();
    public List<Research> Researches = new List<Research>();
    //Methode om een Onderzoek toe te voegen
    public void AddNewResearch(Research research){
        Researches.Add(research);
    }
    //Methode om een gebruikersaccount toe te voegen
    public void AddNewAccount(Employee employee){
        CompanyAccounts.Add(employee);
    }
}