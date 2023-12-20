using System;
using System.Globalization;

public class User
{
    //properties van Gebruiker
    public int ID {get; protected set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Zipcode {get; set;}
    public string HouseNumber {get; set;}
    public DateTime Birthdate {get; set;}
    public string Email {get; set;}
    public string? TelephoneNumber {get; set;}
    public string SortUser {get;set;}

    
    //Constructor met alle kenmerken in de parameters.
    public User()
    {
        
    }   
}


