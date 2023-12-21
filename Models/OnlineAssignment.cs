using System.Reflection.Metadata;

using WPR;

public class OnlineAssignment : Research{
    public string Link{get; set;}
    public string Explanation{get; set;}
    public List<OnlineAssignmentResult> OnlineAssignmentResults = new List<OnlineAssignmentResult>();
    public OnlineAssignment(string titel, string description, string location, string reward, string status,string link, string explanation){
        this.Link = link;
        this.Explanation = explanation;
        this.Title = titel;
        this.Description = description;
        this.Reward = reward;
        this.Status = status;
    }

    private void NewResult(string comment, Specialist specialist){
        OnlineAssignmentResult result = new OnlineAssignmentResult(comment, specialist, this);
        OnlineAssignmentResults.Add(result);

    }
}