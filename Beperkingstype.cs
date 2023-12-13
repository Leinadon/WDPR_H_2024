using System.Collections;
using System.Diagnostics;
using Microsoft.VisualBasic;

public class Beperkingstype
{  
    public int ID{get; private set;}
    public string Type{get; set;}
    public string Details{get; set;}
    public Beperkingstype(string type, string details)
    {   
        this.Type = type;
        this.Details = details;
    }
}