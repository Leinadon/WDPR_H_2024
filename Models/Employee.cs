using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("Employees")]
    public class Employee : OurUser

    {
        [Required] [StringLength(64, MinimumLength =2)]
        public string Function {get; set;}
        public int CompanyId{get; set;}
        [NotMapped][ForeignKey(nameof(CompanyId))]
        public Company? Company {get; set;}
        

        public Employee(){
            Function = string.Empty;
        }

    }
}
   
