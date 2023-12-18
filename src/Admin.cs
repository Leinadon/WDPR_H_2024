using System.Data;

public class Admin : User{
    
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