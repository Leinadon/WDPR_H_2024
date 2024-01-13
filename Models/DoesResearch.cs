using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Graph.Models;

namespace WPR
{
    [Table("DoesResearches")]
    public class DoesResearch{
        [Key] 
        public int ID {get; set;}
        public string SpecialistId{get; set;}
        [ForeignKey(nameof(SpecialistId))]
        public Specialist specialist {get;}
        public int ChatId{get; set;}
        [ForeignKey(nameof(ChatId))]
        public OurChat chat {get;}
        public int ResearchID{get; set;}
        [ForeignKey(nameof(ResearchID))]
        public Research research{get;}
        
        [Required] [StringLength(1024, MinimumLength = 5)] 
        public string Result{get; set;}
        public string InformationTrackingScript{get; set;}
        public Boolean Completed{get; set;}
        public ICollection<OnlineAssignmentResult> OnlineAssignmentResults{get;}
        public ICollection<Answer> Answers{get;}
        public DoesResearch(){
            Completed = false;
        }
    }
}
