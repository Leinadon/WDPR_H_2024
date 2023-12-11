public class DoetOnderzoek
{
    private static int NextID = 1;
    public int ID {get; private set;}
    private Onderzoek Onderzoek{get;}
    private Ervaringsdeskundige Ervaringsdeskundige;
    private string? Resultaat{get; set;}
    private string? InformatieTrackingScript{get; set;}
    private Boolean Voltooid{get; set;}
    private DateTime Created{get;}
    private DateTime LastUpdated{get;set;}

    public DoetOnderzoek(Onderzoek onderzoek, Ervaringsdeskundige ervaringsdeskundige){
        this.Onderzoek = onderzoek;
        this.Ervaringsdeskundige = ervaringsdeskundige;
        this.ID = NextID;
        NextID++;
        Voltooid = false;
        this.Created = setDateTimeNow();
        this.LastUpdated = setDateTimeNow();
    }

    public void setResultaat(string resultaat){
        this.Resultaat = resultaat;
    }
    public void setVoltooid(Boolean voltooid){
        this.Voltooid = voltooid;
    }
    public void setInformatieTrackingScript(String infromatie){
        this.InformatieTrackingScript = infromatie;
    }
    private DateTime setDateTimeNow(){
        return DateTime.Now;
    }  

    
}