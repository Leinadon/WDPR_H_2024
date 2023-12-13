using System.Dynamic;
using System.Runtime.CompilerServices;

//class Antwoord is voor de antwoorden die we kunnen krijgen van vragen die gesteld worden in onderzoeken.
//Antwoord kan op dit moment van een vraag van een interview of van een vraag van een vragenlijst zijn. 
public class Antwoord{
    private static int NextID = 1;
    public int ID {get; private set;}
    public string Text{get; private set;}
    public Vraag Vraag{get; private set;}
    public Ervaringsdeskundige Ervaringsdeskundige{get; private set;}

    public Antwoord(string text, Vraag vraag, Ervaringsdeskundige ervaringsdeskundige){
        this.Text = text;
        this.Vraag = vraag;
        this.Ervaringsdeskundige = ervaringsdeskundige;
        this.ID = NextID;
        NextID++;
        
    }
}