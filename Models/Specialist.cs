using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WPR;

namespace WPR
{
    [Table("Specialists")]
    public class Specialist : User
    {
        public Location Location { get; set; }
        public int LocationId{get; set;}
        public string ToolsUsing { get; set; }
        public MessagePrefence MessagePreference { get; set; }
        public ICollection<DoesResearch> doesResearches {get;} = new List<DoesResearch>();
        public IEnumerable<Disability> Disabilities { get; set; }
        [StringLength(1024, MinimumLength = 2)]
        public string DisabilityNote {  get; set; }
        [Required]
        public bool ApproachCommercialParties { get; set; }
        public string TrackingID { get; set; }
        public Guardian Guardian { get; set; }
        public int GuardianID{get; set;}

        public Specialist(){}
    }

    public enum MessagePrefence
    {
        Phone,
        Portal
    } 
}