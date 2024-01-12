using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("Interviews")]
    public class Interview : Research{
        [InverseProperty("Interview")]
        public List<Question> Questions = new List<Question>();
    }
}
