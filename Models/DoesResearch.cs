using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("DoesResearches")]
    public class DoesResearch{
        [Key] 
        public int ID {get; private set;}
        public Research Research{get;}
        public int ResearchID{get; set;}
        [Required] [StringLength(1024, MinimumLength = 5)] 
        public string Result{get; set;}
        public string InformationTrackingScript{get; set;}
        public Boolean Completed{get; set;}

        public DoesResearch(){
            Completed = false;
        }
    }
}
