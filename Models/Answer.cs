using System.Dynamic;
using System.Runtime.CompilerServices;

//class Antwoord is voor de antwoorden die we kunnen krijgen van vragen die gesteld worden in onderzoeken.
//Antwoord kan op dit moment van een vraag van een interview of van een vraag van een vragenlijst zijn. 
public class Answer{
    public int ID {get; private set;}
    public string Text{get; set;}
    public Question Question{get; set;}
    public Specialist Specialist{get; private set;}

    public Answer(string text, Question question, Specialist specialist){
        this.Text = text;
        this.Question = question;
        this.Specialist = specialist;
    }
}