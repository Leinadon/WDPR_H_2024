using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

//class Antwoord is voor de antwoorden die we kunnen krijgen van vragen die gesteld worden in onderzoeken.
//Antwoord kan op dit moment van een vraag van een interview of van een vraag van een vragenlijst zijn. 
public class Answer{
    public int ID {get; private set;}
    public string Text{get; set;}
    
    public Question Question{get; set;}
<<<<<<< HEAD
    public Specialist Specialist{get; private set;}

    public Answer(string text, Question question, Specialist specialist){
        this.Text = text;
        this.Question = question;
        this.Specialist = specialist;
=======
    public int QuestionID{get; set;}
    
    public Specialist Specialist{get; private set;}
    public int SpecialistID{get; set;}

    public DoesResearch DoesResearch{ get; set;}
    public int DoesResearchID{get;set;}
    public Answer(){
       
        }
>>>>>>> 7d5947f91085ae5a190fd6e6efc1ab6e72d380a3
    }
}