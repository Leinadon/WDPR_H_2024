using System.ComponentModel.DataAnnotations;

namespace WPR
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string[] Sectors { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string Place { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string WebsiteURL { get; set; }
        public string ContactEmail { get; set; }
        public string TrackingID { get; set; }
    }
}
