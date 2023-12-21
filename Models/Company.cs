//Class bedrijf heeft alle informatie over een bedrijf die onderzoeken willen uitvoeren via het protaal.
//Bij een bedrijf kunnen verschillende Bedrijfsaccounts horen. Dit zijn de accounts van medewerkers.

using System.ComponentModel.DataAnnotations;
using WPR.Models;

namespace WPR
{
    public class Company
    {
        [Key]
        public int CompanyId { get; private set; }

        [Required]
        public string Name { get; set; }

        public string Sector { get; set; }

        public Location Location { get; set; }

        public string WebsiteURL { get; set; }

        public string ContactEmail { get; set; }

        public string TrackingID { get; set; }

        public ICollection<Employee> Employees { get; } = new List<Employee>();

        public ICollection<Research> Researches { get; } = new List<Research>();
    }
}