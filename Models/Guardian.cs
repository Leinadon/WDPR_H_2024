using System.ComponentModel.DataAnnotations;

namespace WPR.Models
{
    public class Guardian
    {
        [Key]
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; } 
    }
}