using WPR;

public class Question{
    public int ID {get; private set;}
    public string Text{get; set;}
    public Questionnaire? Questionnaire{get; set;}
    public Interview? Interview{get;set;}
    public List<Answer> Answers = new List<Answer>();
    public Question() {}
}