using System.Dynamic;

public class Voogd
{   
    private static int nextID = 1;
    public int ID {get; private set;}
    private string Voornaam {get; set;}
    private string Achternaam {get; set;}
    private string Telefoonnummer{get; set;}
    private string Email{get; set;}
    private DateTime Created {get; set;}
    private DateTime LastUpdated {get; set;}

    public Voogd(string voornaam, string achernaam, string telefoonnummer, string email)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achernaam;
        this.Telefoonnummer = telefoonnummer;
        this.Email = email;
        this.ID = nextID;
        nextID++;
        this.Created = setDateTimeNow();
        this.LastUpdated = setDateTimeNow();

    }

    //methode die de datum en tijd genereert
    private DateTime setDateTimeNow(){
        return DateTime.Now;
    } 
}