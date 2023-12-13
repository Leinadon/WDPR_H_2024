using System.Dynamic;

public class Voogd
{   
    private static int nextID = 1;
    public int ID {get; private set;}
    public string Voornaam {get; set;}
    public string Achternaam {get; set;}
    public string Telefoonnummer{get; set;}
    public string Email{get; set;}

    public Voogd(string voornaam, string achernaam, string telefoonnummer, string email)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achernaam;
        this.Telefoonnummer = telefoonnummer;
        this.Email = email;
        this.ID = nextID;
        nextID++;

    }
}