using System.Data;

public class Beheerder : Gebruiker{
    
    public Beheerder(string voornaam, string achternaam, string postcode, string email, string? telefoonnummer)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        this.Postcode = postcode;
        this.Email = email;
        this.Telefoonnummer = telefoonnummer;
        this.Rol = "Beheerder";
        this.ID = GetNextID();
        
    }
}