using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace WPR
{
    [Table("Questions")]
    public class Question{
        [Key]
        public int ID {get; set;}
        [Required][StringLength(1024, MinimumLength = 5)]
        public string Text{get; set;}
        public int? QuestionnaireId{get; set;}
        [DeleteBehavior(DeleteBehavior.NoAction)]
        [NotMapped][ForeignKey(nameof(QuestionnaireId))]
        public Questionnaire? Questionnaire{get; set;}
        public int? InterviewId{get; set;}
        [NotMapped][ForeignKey(nameof(InterviewId))]
        public Interview? Interview{get;set;}
        public List<Answer>? Answers {get;}
        public Question()
        {
            Text = string.Empty;

        }
    }
}
