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
namespace WPR
{
    [Table("Answers")]
    public class Answer{
    [Key]
    public int ID {get; private set;}
    [Required] [StringLength(1024, MinimumLength = 5)]
    public string Text{get; set;}
    public Question Question{get; set;}
    public int QuestionID{get; set;}
    public Specialist Specialist{get; private set;}
    public int SpecialistID{get; set;}

    public Answer(){
       
        }
    }
    public class SampleContext : DbContext
    {
        
        public DbSet<Answer> Answers {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            

        }
    }
}