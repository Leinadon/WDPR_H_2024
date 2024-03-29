using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WPR
{
    [Table("Researches")]
    public class Research{
        [Key]
        public int ID {get; set;}
        [Required] [StringLength(64, MinimumLength = 2)]
        public string Title{get; set;}
        [Required] [StringLength(1024, MinimumLength = 2)]
        public string? Description{get; set;}
        public DateTime StartDate{get; set;}
        [Required] [StringLength(256, MinimumLength = 2)]
        public string Reward{get; set;}
        [Required]
        public string Status{get; set;}
        public ICollection<DoesResearch>? doesResearches {get;}
        public int CompanyId{get; set;}
        [NotMapped][ForeignKey(nameof(CompanyId))]
        public Company? Company{get; set;}
        [Required] 
        public Boolean English{get;set;}
        public int? disabilityTypeId{get; set;}
        [NotMapped][ForeignKey(nameof(disabilityTypeId))]
        public DisabilityType disabilityType {get; set;}
        public Research()
        {
            Title = string.Empty;
            Reward = string.Empty;
            Status = string.Empty;

            
        }
    }
}
