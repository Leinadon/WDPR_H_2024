public class DoesResearch
{
    public int ID {get; private set;}
    public Research Research{get;}
    public Specialist Specialist {get; set;}
    public string? Result{get; set;}
    public string? InformationTrackingScript{get; set;}
    public Boolean Completed{get; set;}

    public DoesResearch(Research research, Specialist specialist){
        this.Research = research;
        this.Specialist = specialist;
        Completed = false;
    }
    public void SetResult(String result){
        this.Result = result;
    }
    public void SetInformationScript(String informationTrackingScript){
        this.InformationTrackingScript = informationTrackingScript;
    }
    public void SetCompleted(Boolean completed){
        this.Completed = completed;
    }
}