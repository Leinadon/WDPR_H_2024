using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("OnlineAssignmentResults")]
    public class OnlineAssignmentResult{
    [Key]
    public int ID{get; private set;}
    public Boolean Completed{get; set;}
    [StringLength(1024, MinimumLength = 5)]
    public string Comment{get; set;}
    public int SpecialistID{get; set;}
    [ForeignKey(nameof(SpecialistID))]
    public Specialist Specialist{get; set;}
    public int OnlineAssignmentID{get; set;}

    [ForeignKey(nameof(OnlineAssignmentID))]
    public OnlineAssignment OnlineAssignment{get; set;}
    

    public OnlineAssignmentResult(){
        
    }
}
}

