using System.ComponentModel.DataAnnotations;

namespace WPR
{
    public class Disability
    {
        [Key]
        public int DisabilityId { get; private set; }
    }
}
