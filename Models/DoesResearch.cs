using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("DoesResearches")]
    public class DoesResearch{
        [Key] 
        public int ID {get; private set;}
        public int SpecialistId{get; set;}
        [ForeignKey(nameof(SpecialistId))]
        public Specialist Specialist {get;}
        public int ChatId{get; set;}
        [ForeignKey(nameof(ChatId))]
        public Chat Chat {get;}
        public int ResearchID{get; set;}
        [ForeignKey(nameof(ResearchID))]
        public Research Research{get;}
        
        [Required] [StringLength(1024, MinimumLength = 5)] 
        public string Result{get; set;}
        public string InformationTrackingScript{get; set;}
        public Boolean Completed{get; set;}
        [InverseProperty("DoesResearch")]
        public ICollection<Answer> Answers{get;} = new List<Answer>();
        public DoesResearch(){
            Completed = false;
        }
    }
}
