using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;


namespace WPR
{
    [Table("Answers")]
    public class Answer
    {  
        [Key]
        public int ID {get; private set;}
        public string Text{get; set;}
        public int QuestionID{get; set;}

        [ForeignKey(nameof(QuestionID))]
        public Question Question{get; set;}
        
        [ForeignKey(nameof(SpecialistID))]
        public Specialist Specialist{get; private set;}
        public int SpecialistID{get; set;}

        [ForeignKey(nameof(DoesResearchID))]
        public DoesResearch DoesResearch{ get; set;}
        public int DoesResearchID{get;set;}
        public Answer()
        {
        
        }
    }
}

