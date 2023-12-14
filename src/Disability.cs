
using Microsoft.VisualBasic;

public class Disability
{
    public int ID {get; private set;}

    public Specialist Specialist {get; set;}
    
    public string? Details{get; private set;}

    public Disability(Specialist specialist, string? details)
    {
        this.Specialist = specialist;
        this.Details = details;
    }
}