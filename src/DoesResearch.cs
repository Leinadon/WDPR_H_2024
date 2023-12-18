public class DoesResearch
{
    public int ID {get; private set;}
    public Research Research{get;}
    public string? Result{get; set;}
    public string? InformationTrackingScript{get; set;}
    public Boolean Completed{get; set;}

    public DoesResearch(Research research){
        this.Research = research;
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