
using Microsoft.VisualBasic;

public class Beperking
{
    private static int NextID = 1;
    public int ID {get; private set;}

    private Ervaringsdeskundige ervaringsdeskundige;
    
    private string? Details;

   

    public Beperking(Ervaringsdeskundige ervaringsdeskundige, string? details)
    {
        this.ervaringsdeskundige = ervaringsdeskundige;
        this.Details = details;
        this.ID = NextID;
        NextID++;
    }


}