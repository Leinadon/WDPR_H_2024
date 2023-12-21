using System.Collections;
using System.Diagnostics;
using Microsoft.VisualBasic;

public class DisabilityType
{  
    public int ID{get; private set;}
    public string Type{get; set;}
    public string Details{get; set;}

    public DisabilityType(string type, string details)
    {   
        this.Type = type;
        this.Details = details;
    }
}