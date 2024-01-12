
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("Disabilitys")]
    public class Disability
    {
        [Key]
        public int DisabilityId { get; set; }
        public int DisabilityTypeId {get ;set;}
        [ForeignKey(nameof(DisabilityTypeId))]
        public DisabilityType DisabilityType {get; set;}
        public int SpecialistId {get; set;}
        [ForeignKey(nameof(SpecialistId))]
        public Specialist Specialist { get; private set; }
        
        [Required] [StringLength(1024, MinimumLength =5)]
        public string Details { get; set; }

        public Disability() { }
    }
}