using System;
using System.Globalization;

public class User
{
    //properties van Gebruiker
    public int ID {get; protected set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Zipcode {get; set;}
    public string Email {get; set;}
    public string? TelephoneNumber {get; set;}
    public string SortUser {get;set;}

    //Default constructor
    public User(){
        this.ID= 0;
        this.FirstName ="Default voornaam";
        this.LastName ="Default achternaam";
        this.Zipcode = "Default postcode";
        this.Email = "Default email";
        this.TelephoneNumber = "Default telefoonnummer";
        this.SortUser = "Default rol";
    }
    
    //Constructor met alle kenmerken in de parameters.
    public User(string firstName, string lastname, string zipcode, string email, string? telephoneNumber, string sortUser)
    {
        this.FirstName = firstName;
        this.LastName = lastname;
        this.Zipcode = zipcode;
        this.Email = email;
        this.TelephoneNumber = telephoneNumber;
        this.SortUser = sortUser; 
    }   
}


