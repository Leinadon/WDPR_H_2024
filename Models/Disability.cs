
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("Disabilities")]
    public class Disability
    {
        [Key]
        public int DisabilityId { get; set; }
        public int DisabilityTypeId {get ;set;}
        [NotMapped][ForeignKey(nameof(DisabilityTypeId))]
        public DisabilityType? DisabilityType {get; set;}
        public string SpecialistId {get; set;}
        [NotMapped][ForeignKey(nameof(SpecialistId))]
        public Specialist? Specialist { get; private set; }
        
        [Required] [StringLength(1024, MinimumLength =5)]
        public string Details { get; set; }

        public Disability() {
            Details = string.Empty;
            SpecialistId = string.Empty;

        }
    }
}