using System.Dynamic;

public class Vraag{
    public int ID {get; private set;}
    public string Text{get; set;}
    public Vragenlijst? Vragenlijst{get; set;}
    public Interview? Interview{get;set;}
    public List<Antwoord> Antwoorden = new List<Antwoord>();
    public Vraag(string text, Vragenlijst vragenlijst)
    {
        this.Text = text;
        this.Vragenlijst = vragenlijst;
    }
    public Vraag(string text, Interview interview)
    {
        this.Text = text;
        this.Interview = interview;
    }

    public void VoegNieuweAntwoordToe(string antwoord, Ervaringsdeskundige ervaringsdeskundige)
    {
        Antwoord AntwoordObject = new Antwoord(Text,this,ervaringsdeskundige);
        Antwoorden.Add(AntwoordObject);
    }
}