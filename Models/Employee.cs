using System.ComponentModel.Design.Serialization;
using System.Data;
namespace WPR
{
    public class Employee : User
    {
        public string? Function {get; set;}
        public Company Company {get; set;}
    }
}
   
