using System.Data;
//Class Admin is het object van een gebruiker account die adminstrator is
public class Admin : User{
    //constructor
    public Admin(string firstName, string lastname, string zipcode, string email, string? telephoneNumber)
    {
        this.FirstName = firstName;
        this.LastName = lastname;
        this.Zipcode = zipcode;
        this.Email = email;
        this.TelephoneNumber = telephoneNumber;
        this.SortUser = "Admin";
    }
}