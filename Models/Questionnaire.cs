using System.ComponentModel.DataAnnotations.Schema;
namespace WPR
{
    [Table("Questionnaires")]
    public class Questionnaire : Research{
        public ICollection<Question>? Questions {get; set;}
        
        public Questionnaire()
        {
            this.StartDate = DateTime.Now;
            
        }
    }
}
