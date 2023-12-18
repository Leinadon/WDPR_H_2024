namespace WPR.Models
{
    public enum MessagePrefence
    {
        Phone,
        Portal
    }

    public class Specialist: User
    {
        public string ToolsUsing { get; set; }
        public MessagePrefence MessagePreference { get; set; }
        public string[] Disabilities { get; set; }
        public string DisabilityNote {  get; set; }
        public bool ApproachCommercialParties { get; set; }
        public string TrackingID { get; set; }
        public Guardian Guardian { get; set; }
        // public ?? Availability { get; set; }

    }
}
