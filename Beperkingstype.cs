using System.Collections;
using System.Diagnostics;
using Microsoft.VisualBasic;

public class Beperkingstype
{  
    private static int nextID = 1;
    public int ID{get; private set;}
    private string Type;
    private string Details;
    public Beperkingstype(string type, string details)
    {   
        this.Type = type;
        this.Details = details;
        this.ID = nextID;
        nextID++;
    }
}