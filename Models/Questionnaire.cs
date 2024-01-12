using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
namespace WPR
{
    [Table("Questionnaires")]
    public class Questionnaire : Research{
        [InverseProperty("Questionnaire")]
        public List<Question> Questions = new List<Question>();
        
        public Questionnaire()
        {
            this.StartDate = DateTime.Now;
            
        }
    }
}
