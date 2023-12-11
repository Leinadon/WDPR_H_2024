using System.Dynamic;
using System.Runtime.CompilerServices;

//class Antwoord is voor de antwoorden die we kunnen krijgen van vragen die gesteld worden in onderzoeken.
//Antwoord kan op dit moment van een vraag van een interview of van een vraag van een vragenlijst zijn. 
public class Antwoord{
    private static int NextID = 1;
    public int ID {get; private set;}
    private string Text{get; set;}
    private Vraag Vraag{get; set;}
    private Ervaringsdeskundige Ervaringsdeskundige{get; set;}
    private DateTime Created{get; set;}
    private DateTime LastUpdated{get; set;}

    public Antwoord(string text, Vraag vraag, Ervaringsdeskundige ervaringsdeskundige){
        this.Text = text;
        this.Vraag = vraag;
        this.Ervaringsdeskundige = ervaringsdeskundige;
        this.ID = NextID;
        NextID++;
        this.Created = setDateTimeNow();
        this.LastUpdated = setDateTimeNow();
    }
    //Datum en tijd genereren van dit moment.
    protected DateTime setDateTimeNow(){
        return DateTime.Now;
    } 
}