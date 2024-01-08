using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("Interviews")]
    public class Interview : Research{
        [InverseProperty("Questions")]
        public List<Question> Questions = new List<Question>();
        public Specialist Specialist{get; set;}
        public int SpecialistID{get; set;} 

        public Interview(){
            
        }
        private void AddQuestion(string text){
            Question question = new Question();
            this.Questions.Add(question);
            
        }
    }
}
