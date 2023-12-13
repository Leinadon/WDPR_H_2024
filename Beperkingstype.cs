using System.Collections;
using System.Diagnostics;
using Microsoft.VisualBasic;

public class Beperkingstype
{  
    private static int nextID = 1;
    public int ID{get; private set;}
    public string Type{get; private set;}
    public string Details{get; private set;}
    public Beperkingstype(string type, string details)
    {   
        this.Type = type;
        this.Details = details;
        this.ID = nextID;
        nextID++;
    }
}