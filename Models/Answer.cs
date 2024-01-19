using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace WPR
{
    [Table("Answers")]
    public class Answer
    {  
        [Key]
        public int ID {get; set;}
        public string Text{get; set;}
        public int QuestionID{get; set;}

        [ForeignKey(nameof(QuestionID))]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        
        public Question? Question{get; set;}
        
        [ForeignKey(nameof(SpecialistID))]
        public Specialist? Specialist{get; private set;}
        public string SpecialistID{get; set;}

        [ForeignKey(nameof(DoesResearchID))]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public DoesResearch? DoesResearch{ get; set;}
        public int DoesResearchID{get;set;}
        public Answer()
        {
            Text = string.Empty;
            SpecialistID = string.Empty;

        }
    }
}

