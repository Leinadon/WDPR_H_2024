using System.Dynamic;

public class Vraag{
    private static int NextID = 1;
    public int ID {get; private set;}
    private string Text{get; set;}
    private DateTime Created {get; set;}
    private DateTime LastUpdated {get; set;}
    private Vragenlijst? Vragenlijst{get; set;}
    private Interview? Interview{get;set;}
    private List<Antwoord> Antwoorden = new List<Antwoord>();
    public Vraag(string text, Vragenlijst vragenlijst)
    {
        this.Text = text;
        this.ID = NextID;
        this.Vragenlijst = vragenlijst;
        NextID++;
        this.Created = setDateTimeNow();
        this.LastUpdated = setDateTimeNow();
    }
    public Vraag(string text, Interview interview)
    {
        this.Text = text;
        this.ID = NextID;
        this.Interview = interview;
        NextID++;
        this.Created = setDateTimeNow();
        this.LastUpdated = setDateTimeNow();
    }

    public void VoegNieuweAntwoordToe(string antwoord, Ervaringsdeskundige ervaringsdeskundige)
    {
        Antwoord AntwoordObject = new Antwoord(Text,this,ervaringsdeskundige);
        Antwoorden.Add(AntwoordObject);
    }
    protected DateTime setDateTimeNow(){
        return DateTime.Now;
    } 
}