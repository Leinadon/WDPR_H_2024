using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design.Serialization;
using System.Data;
namespace WPR
{
    [Table("Employees")]
    public class Employee : User

    {
        [Required] [StringLength(64, MinimumLength =2)]
        public string Function {get; set;}
        public int CompanyId{get; set;}
        [ForeignKey(nameof(CompanyId))]
        public Company? Company {get; set;}
        

        public Employee(){
            Function = string.Empty;
        }

    }
}
   
