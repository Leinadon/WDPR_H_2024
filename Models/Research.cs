using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
namespace WPR
{
    [Table("Researches")]
    public class Research{
        [Key]
        public int ID {get; private set;}
        [Required] [StringLength(64, MinimumLength = 2)]
        public string Title{get; set;}
        [Required] [StringLength(1024, MinimumLength = 2)]
        public string? Description{get; set;}
        public DateTime StartDate{get; set;}
        public string? Location{get; set;}
        [Required] [StringLength(256, MinimumLength = 2)]
        public string Reward{get; set;}
        [Required]
        public string Status{get; set;}
        [InverseProperty("Research")]
        public ICollection<DoesResearch> doesResearches {get;} = new List<DoesResearch>();
        public int CompanyId{get; set;}
        [ForeignKey(nameof(CompanyId))]
        public Company Company{get; set;}
        [Required]
        public Boolean English{get;set;}
        public Research()
        {
            this.StartDate = DateTime.Now;
        }
    }
}
