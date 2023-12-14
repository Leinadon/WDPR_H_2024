using System;
using System.Globalization;
using System.Linq.Expressions;


public class Specialist : User
{
    public string? ContactPreference {get; set;}
    public DateTime? Availability { get; set; }
    public Boolean ApproachCommercialParties {get; set;}
    public Boolean HasGuardian {get; set;}
    public List<Research> researches = new List<Research>();
    public Specialist(string firstName, string lastName, string zipcode, string email, string? telephoneNumber, string? contactPreference, DateTime?  availability, Boolean approachCommercialParties, Boolean hasGuardian)
    {   
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Zipcode = zipcode;
        this.Email = email;
        this.TelephoneNumber = telephoneNumber;
        this.SortUser = "Specialist";
        this.ContactPreference = contactPreference;
        this.Availability = availability;
        this.ApproachCommercialParties = approachCommercialParties;
        this.HasGuardian = hasGuardian;
    }

    public void VoegNieuweOnderzoekToe(Research research){
        researches.Add(research);
    }
}
    






