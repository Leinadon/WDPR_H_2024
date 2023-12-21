namespace WPR
{
    public class OnlineAssignmentResult{
    public int ID{get; private set;}
    public Boolean Completed{get; set;}
    public string Comment{get; set;}
    public Specialist Specialist{get; set;}
    public OnlineAssignment OnlineAssignment{get; set;}


    public OnlineAssignmentResult(string comment, Specialist specialist, OnlineAssignment onlineAssignment){
        this.Completed = false;
        this.Comment = comment;
        this.Specialist = specialist;
        this.OnlineAssignment = onlineAssignment;
    }
}
}

