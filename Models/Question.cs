using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
namespace WPR
{
    [Table("Questions")]
    public class Question{
        [Key]
        public int ID {get; set;}
        [Required][StringLength(1024, MinimumLength = 5)]
        public string Text{get; set;}
        public int QuestionnaireId{get; set;}
        [ForeignKey(nameof(QuestionnaireId))]
        public Questionnaire? Questionnaire{get; set;}
        public int InterviewId{get; set;}
        [ForeignKey(nameof(InterviewId))]
        public Interview? Interview{get;set;}
        public List<Answer> Answers {get;}
        public Question()
        {
            
        }
    }
}
