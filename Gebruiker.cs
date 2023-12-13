using System;
using System.Globalization;

public class Gebruiker
{
    //properties van Gebruiker
    public int ID {get; protected set;}
    public string Voornaam {get; set;}
    public string Achternaam {get; set;}
    public string Postcode {get; set;}
    public string Email {get; set;}
    public string? Telefoonnummer {get; set;}
    public string Rol {get;set;}

    //Default constructor
    public Gebruiker(){
        this.ID= 0;
        this.Voornaam ="Default voornaam";
        this.Achternaam ="Default achternaam";
        this.Postcode = "Default postcode";
        this.Email = "Default email";
        this.Telefoonnummer = "Default telefoonnummer";
        this.Rol = "Default rol";
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
    }   
}


