using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using Microsoft.VisualBasic;
namespace WPR
{
    [Table("DisabilityTypes")]
    public class DisabilityType
    {  
        [Key]
        public int ID{get; private set;}
        public string Type{get; set;}
        public string Details{get; set;}
        [InverseProperty("DisabilityType")]
        public ICollection<Disability> disabilities{get;} = new List<Disability>();
        public DisabilityType()
        {   

        }
    }
}
