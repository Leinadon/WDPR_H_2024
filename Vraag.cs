using System.Dynamic;

public class Vraag{
    private static int NextID = 1;
    public int ID {get; private set;}
    public string Text{get; set;}
    public DateTime CreatedDate {get; set;}
    public DateTime LastUpdated {get; set;}
    public Vragenlijst? Vragenlijst{get; set;}
    public Interview? Interview{get;set;}
    public List<Antwoord> Antwoorden = new List<Antwoord>();
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