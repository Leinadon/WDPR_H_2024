using System;
using System.Globalization;

public class Gebruiker
{
    //Static attirbuut currentID zorgt ervoor dat elke Gebruiker die aangemaakt wordt een andere ID krijgt.
    private static int CurrentID;

    //properties van Gebruiker
    public int ID {get; protected set;}
    protected string Voornaam {get; set;}
    protected string Achternaam {get; set;}
    protected string Postcode {get; set;}
    protected string Email {get; set;}
    protected string? Telefoonnummer {get; set;}
    protected string Rol {get;set;}
    protected DateTime Created {get; set;}
    protected DateTime LastUpdate {get; set;}

    //Default constructor
    public Gebruiker(){
        this.ID= 0;
        this.Voornaam ="Default voornaam";
        this.Achternaam ="Default achternaam";
        this.Postcode = "Default postcode";
        this.Email = "Default email";
        this.Telefoonnummer = "Default telefoonnummer";
        this.Rol = "Default rol";
        this.Created = setDateTimeNow();
        this.LastUpdate = setDateTimeNow();
    }
    
    //Constructor met alle kenmerken in de parameters.
    public Gebruiker(string voornaam, string achternaam, string postcode, string email, string? telefoonnummer, string rol)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        this.Postcode = postcode;
        this.Email = email;
        this.Telefoonnummer = telefoonnummer;
        this.Rol = rol; 
        this.Created = setDateTimeNow();
        this.LastUpdate = setDateTimeNow();
    }

    // statische contstructor om de statische ID te initialiseren. 
    static Gebruiker() => CurrentID = 0;

    //Methode die voor elke child object een id genereert. 
    protected int GetNextID() => ++CurrentID;

    //methode die de datum en tijd genereert
    protected DateTime setDateTimeNow(){
        return DateTime.Now;
    }    
}


