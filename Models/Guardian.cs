using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("Guardians")]
    public class Guardian
    {
        [Key]
        public int Id { get; private set; }
        [Required] [StringLength(64, MinimumLength =2)]

        public string FirstName { get; set; }
        [Required] [StringLength(64, MinimumLength =2)]

        public string LastName { get; set; }
        [Required] [StringLength(64, MinimumLength =2)]

        public string Phone { get; set; }
        [Required] [StringLength(64, MinimumLength =2)]
        public Specialist specialist {get; set;}
        public string Email { get; set; } 

        public Guardian(){}
    }
}