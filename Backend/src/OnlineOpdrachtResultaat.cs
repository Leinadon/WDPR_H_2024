public class OnlineOpdrachtResultaat{
    public int ID{get; private set;}
    public Boolean Afgerond{get; set;}
    public string Opmerking{get; set;}
    public Ervaringsdeskundige Ervaringsdeskundige{get; set;}
    public OnlineOpdracht OnlineOpdracht{get; set;}


    public OnlineOpdrachtResultaat(string opmerking, Ervaringsdeskundige ervaringsdeskundige, OnlineOpdracht onlineOpdracht){
        this.Afgerond = false;
        this.Opmerking = opmerking;
        this.Ervaringsdeskundige = ervaringsdeskundige;
        this.OnlineOpdracht = onlineOpdracht;
    }
}
