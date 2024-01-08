using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
namespace WPR
{
    [Table("Questionnaires")]
    public class Questionnaire : Research{
        [InverseProperty("Questions")]
        public List<Question> Questions = new List<Question>();
        
        public Questionnaire()
        {
            this.StartDate = DateTime.Now;
            
        }
        private void AddQuestion(string text){
            Question question = new Question();
            Questions.Add(question);
        }
    }
}
