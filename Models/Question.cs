using WPR;

public class Question{
    public int ID {get; private set;}
    public string Text{get; set;}
    public Questionnaire? Questionnaire{get; set;}
    public Interview? Interview{get;set;}
    public List<Answer> Answers = new List<Answer>();
    public Question(string text, Questionnaire questionnaire)
    {
        this.Text = text;
        this.Questionnaire = questionnaire;
    }
    public Question(string text, Interview interview)
    {
        this.Text = text;
        this.Interview = interview;
    }

    public void VoegNieuweAntwoordToe(string Answer, Specialist specialist)
    {
        Answer AnswerObject = new Answer(Text,this,specialist);
        Answers.Add(AnswerObject);
    }
}