using System.ComponentModel.Design.Serialization;
using System.Data;

public class Employee : User
{
    public string? Function {get; set;}
    public Boolean Admin {get; set;}
    public Company Company {get; set;}

    public Employee(string firstName, string lastName, string zipcode, string email, string telephoneNumber, string function, Boolean admin, Company company)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Function = function;
        this.Admin = admin;
        this.Company = company;
        Company.AddNewAccount(this);
    }
}   
