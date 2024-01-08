using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
namespace WPR
{
    [Table("Questions")]
    public class Question{
        [Key]
        public int ID {get; private set;}
        [Required][StringLength(1024, MinimumLength = 5)]
        public string Text{get; set;}
        public Questionnaire? Questionnaire{get; set;}
        public Interview? Interview{get;set;}
        public List<Answer> Answers = new List<Answer>();
        public Question()
        {
            
        }

        public void VoegNieuweAntwoordToe(string Answer, Specialist specialist)
        {
            Answer AnswerObject = new Answer();
            Answers.Add(AnswerObject);
        }
    }
}
