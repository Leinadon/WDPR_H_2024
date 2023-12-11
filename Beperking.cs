
using Microsoft.VisualBasic;

public class Beperking
{
    private static int NextID = 1;
    public int ID {get; private set;}

    private Ervaringsdeskundige ervaringsdeskundige {get; set;}
    
    private string? Details{get; set;}

    public Beperking(Ervaringsdeskundige ervaringsdeskundige, string? details)
    {
        this.ervaringsdeskundige = ervaringsdeskundige;
        this.Details = details;
        this.ID = NextID;
        NextID++;
    }


}