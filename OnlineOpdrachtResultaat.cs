public class OnlineOpdrachtResultaat{
    private static int NextID =1;
    public int ID{get; private set;}
    public Boolean Afgerond{get; set;}
    public string Opmerking{get; set;}
    public Ervaringsdeskundige Ervaringsdeskundige{get; set;}
    public OnlineOpdracht OnlineOpdracht{get; set;}
    public DateTime Created {get; set;}
    public DateTime LastUpdated {get; set;}


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
