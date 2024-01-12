using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("Interviews")]
    public class Interview : Research{
        
        public List<Question> Questions {get;}
    }
}
