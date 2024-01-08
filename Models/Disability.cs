
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("Disabilitys")]
    public class Disability
    {
        [Key]
        public int DisabilityId { get; private set; }
        public DisabilityType DisabilityType {get; set;}
        public Specialist Specialist { get; private set; }
        public int SpecialistID{get; set;}
        [Required] [StringLength(1024, MinimumLength =5)]
        public string Details { get; set; }

        public Disability() { }
    }
}