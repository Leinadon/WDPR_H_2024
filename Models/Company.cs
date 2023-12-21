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

        public Location Location { get; set; }

        public string Sectors { get; set; }
        
        public string WebsiteURL { get; set; }

        public string ContactEmail { get; set; }

        public string TrackingID { get; set; }
    }
}
