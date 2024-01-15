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
        public List<OnlineAssignmentResult>? OnlineAssignmentResults {get;}
        public OnlineAssignment(){ 
            Link = string.Empty;
            Explanation = string.Empty;

        }
    }
}
