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
    public Specialist Specialist{get; set;}
    public int SpecialistID{get; set;}
    public OnlineAssignment OnlineAssignment{get; set;}
    public int OnlineAssignmentID{get; set;}


    public OnlineAssignmentResult(string comment, Specialist specialist, OnlineAssignment onlineAssignment){
        this.Completed = false;
        this.Comment = comment;
        this.Specialist = specialist;
        this.OnlineAssignment = onlineAssignment;
    }
}
}

