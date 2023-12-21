
namespace WPR
{
    public class Disability
    {
        public int DisabilityId { get; private set; }

        public Specialist Specialist { get; private set; }

        public string Details { get; set; }

        public Disability() { }
    }
}