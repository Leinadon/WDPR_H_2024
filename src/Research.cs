using System.Runtime.CompilerServices;

public class Research{
    public int ID {get; protected set;}
    public string Titel{get; set;}
    public string? Description{get; set;}
    public DateTime OprichtingsDatum{get; set;}
    public string? Location{get; set;}
    public string? Reward{get; set;}
    public string? Status{get; set;}
    public List<Specialist> Specialists = new List<Specialist>();
    public Company Company{get; set;}
    public Boolean English{get;set;}

    //Default constructor
    public Research(){
        this.ID=0;
        this.Titel = "Default voornaam";
        this.Reward = "Defeault belonging";
        this.Description = "Default beschrijving";
        this.Location = "Default Locatie";
        this.OprichtingsDatum = DateTime.Now;
        this.Company = new Company("Default naam", "Default Branche", "Default Locatie", "Default Link", "Default Email");
        this.English = false;
    }
    public Research(string titel, string? description, string? location, string? reward, string? status, Company company , Boolean english)
    {
        this.Titel = titel;
        this.Description = description;
        this.Location = location;
        this.Reward = Reward;
        this.Status = status;
        this.English = english;
        this.OprichtingsDatum = DateTime.Now;
        this.Company = company;
        

    }
    public void AddNewSpecialist(Specialist specialist){
        Specialists.Add(specialist);
    }
}