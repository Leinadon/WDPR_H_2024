using System.ComponentModel.Design.Serialization;
using System.Data;

public class CompanyAccount : User
{
    public string? Function {get; set;}
    public Boolean Admin {get; set;}
    public Company Company {get; set;}

    public CompanyAccount(string firstName, string lastName, string zipcode, string email, string telephoneNumber, string function, Boolean admin, Company company)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Zipcode = zipcode;
        this.Email = email;
        this.TelephoneNumber = telephoneNumber;
        this.SortUser = "Company User";
        this.Function = function;
        this.Admin = admin;
        this.Company = company;
        Company.AddNewAccount(this);
    }
}   
