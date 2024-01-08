public abstract class Research
{

    public int ResearchId { get; private set; }

    public string Title { get; set; }

    public string? Description { get; set; }

    public DateTime CreationDate { get; set; }

    public string? Reward { get; set; }
    public string? Status { get; set; }

    protected Research() { }
}

public class Questionnaire : Research
{
    public List<Question> Questions { get; } = new List<Question>();

    public Questionnaire() : base() { }
}

public class Interview : Research
{
    public List<Question> Questions { get; } = new List<Question>();

    public Interview() : base() { }
}

public class OnlineAssignment : Research
{
    public string Link { get; set; }
    public string Explanation { get; set; }
    public OnlineAssignment() : base() {}
}