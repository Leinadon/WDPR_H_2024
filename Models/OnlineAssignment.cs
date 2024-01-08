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
        public OnlineAssignment(string titel, string description, string location, string reward, string status,string link, string explanation){ 
            this.Link = link;
            this.Explanation = explanation;
            this.Title = titel;
            this.Description = description;
            this.Location = location;
            this.Reward = reward;
            this.Status = status;
        }

        private void NewResult(string comment, Specialist specialist){
            OnlineAssignmentResult result = new OnlineAssignmentResult(comment, specialist, this);
            OnlineAssignmentResults.Add(result);

        }
    }
}
