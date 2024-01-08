using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
namespace WPR
{
    [Table("OnlineAssignments")]
    public class OnlineAssignment : Research{
        [Required][StringLength(1024, MinimumLength = 5)]
        public string Link{get; set;}
        [Required][StringLength(1024, MinimumLength = 5)]
        public string Explanation{get; set;}
        [InverseProperty("OnlineAssignmentResults")]
        public List<OnlineAssignmentResult> OnlineAssignmentResults = new List<OnlineAssignmentResult>();
        public OnlineAssignment(){ 
            
        }

        private void NewResult(string comment, Specialist specialist){
            OnlineAssignmentResult result = new OnlineAssignmentResult();
            OnlineAssignmentResults.Add(result);

        }
    }
}
