public class OnlineOpdrachtResultaat{
    private static int NextID =1;
    public int ID{get; private set;}
    private Boolean Afgerond{get; set;}
    private string Opmerking{get; set;}
    private Ervaringsdeskundige Ervaringsdeskundige{get; set;}
    private OnlineOpdracht OnlineOpdracht{get; set;}
    private DateTime Created {get; set;}
    private DateTime LastUpdated {get; set;}


    public OnlineOpdrachtResultaat(string opmerking, Ervaringsdeskundige ervaringsdeskundige, OnlineOpdracht onlineOpdracht){
        this.Afgerond = false;
        this.Opmerking = opmerking;
        this.Ervaringsdeskundige = ervaringsdeskundige;
        this.OnlineOpdracht = onlineOpdracht;
        this.Created =setDateTimeNow();
        this.LastUpdated = setDateTimeNow();
        this.ID = NextID;
        NextID++;
    }
    private DateTime setDateTimeNow(){
        return DateTime.Now;
    } 
}
