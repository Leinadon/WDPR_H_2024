using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("Locations")]
    public class Location
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id {get; private set;}
        [Required][StringLength(256, MinimumLength = 2)]
        public string StreetName { get; set; }
        [Required][StringLength(6, MinimumLength = 6)]
        public string PostalCode { get; set; }
        [Required][StringLength(10, MinimumLength = 1)]
        public string HouseNumber { get; set; }
        [Required][StringLength(64, MinimumLength = 2)]
        public string Place { get; set; }
        public Location(){
            StreetName = string.Empty;
            PostalCode = string.Empty;
            HouseNumber = string.Empty;
            Place = string.Empty;
        }
    }
}

