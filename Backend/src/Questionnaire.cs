using System.Reflection;

public class Questionnaire : Research{
    public List<Question> Questions = new List<Question>();
     
    public Questionnaire(string titel, string? description, string? location, string? reward, string status, Company company)
    {
        this.Titel = titel;
        this.Description = description;
        this.Location = location;
        this.Reward = reward;
        this.Status = status;
        this.Company = company;
    }
    private void AddQuestion(string text){
        Question question = new Question(text, this);
        Questions.Add(question);
    }
}