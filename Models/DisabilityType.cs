using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("DisabilityTypes")]
    public class DisabilityType
    {  
        [Key]
        public int ID{get; set;}
        public string Type{get; set;}
        public string Details{get; set;}
        public ICollection<Disability>? disabilities{get;}
        public DisabilityType()
        {   
            Type = string.Empty;
            Details = string.Empty;

        }
    }
}
