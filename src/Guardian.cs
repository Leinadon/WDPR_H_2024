using System.Dynamic;

public class Guardian
{   
    public int ID {get; private set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string TelephoneNumber{get; set;}
    public string Email{get; set;}

    public Guardian(string firstName, string lastName, string telephoneNumber, string email)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.TelephoneNumber = telephoneNumber;
        this.Email = email;
    }
}