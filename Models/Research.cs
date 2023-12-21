using System.Runtime.CompilerServices;

public abstract class Research
{

    public int ResearchId { get; private set; }

    public string Title { get; set; }

    public string? Description { get; set; }

    public DateOnly CreationDate { get; set; }

    public string? Reward { get; set; }
    public string? Status { get; set; }   
}

public class Questionnaire : Research
{
    public List<Question> Questions = new List<Question>();
}

public class Interview : Research
{
    public List<Question> Questions = new List<Question>();
}