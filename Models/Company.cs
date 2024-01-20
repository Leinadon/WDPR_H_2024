//Class bedrijf heeft alle informatie over een bedrijf die onderzoeken willen uitvoeren via het protaal.
//Bij een bedrijf kunnen verschillende Bedrijfsaccounts horen. Dit zijn de accounts van medewerkers.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPR
{
    [Table("Companys")]
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required] [StringLength(64, MinimumLength =2)]
        public string Name { get; set; }

        [Required] [StringLength(64, MinimumLength =2)]
        public string Sector { get; set; }

        [StringLength(1024, MinimumLength =5)]
        public string WebsiteURL { get; set; }
        [Required] [StringLength(320, MinimumLength =5)]
        public string ContactEmail { get; set; }
        
        public string TrackingID { get; set; }
        
        public List<Employee>? Employees { get; }
        
        public List<Research>? Researches { get; }
        public string LocationId{get ;set;}
        [NotMapped][ForeignKey(nameof(LocationId))]
        public Location Location {get; set;}
        public Company(){
            Name = string.Empty;
            WebsiteURL = string.Empty;
            ContactEmail = string.Empty;
            TrackingID = string.Empty;
            Sector = string.Empty;
        }
    }
}