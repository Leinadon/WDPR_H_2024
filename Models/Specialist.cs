using WPR;

namespace WPR
{
    public class Specialist : User
    {
        public Location Location { get; set; }

        public string ToolsUsing { get; set; }
        public MessagePrefence MessagePreference { get; set; }

        public IEnumerable<Disability> Disabilities { get; set; }

        public string DisabilityNote {  get; set; }
        public bool ApproachCommercialParties { get; set; }
        public string TrackingID { get; set; }
        public Guardian Guardian { get; set; }
    }

    public enum MessagePrefence
    {
        Phone,
        Portal
    } 
}