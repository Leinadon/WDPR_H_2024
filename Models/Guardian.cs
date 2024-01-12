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
        [Required] [StringLength(15, MinimumLength =5)]
        public string Phone { get; set; }
        [Required] [StringLength(320, MinimumLength =5)]
        public string Email { get; set; } 
        public int SpecialistID {get; set;}
        [ForeignKey(nameof(SpecialistID))]
        public Specialist specialist {get; set;}
        

        public Guardian(){}
    }
}