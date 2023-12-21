using System.Runtime.CompilerServices;
namespace WPR
{
    public class Research{
        public int ID {get; protected set;}
        public string Title{get; set;}
        public string? Description{get; set;}
        public DateTime StartDate{get; set;}
        public string? Location{get; set;}
        public string? Reward{get; set;}
        public string? Status{get; set;}
        public List<Specialist> Specialists = new List<Specialist>();
        public Company Company{get; set;}
        public Boolean English{get;set;}

        //Default constructor
        public Research(){
            this.ID=0;
            this.Title = "Default voornaam";
            this.Reward = "Defeault belonging";
            this.Description = "Default beschrijving";
            this.Location = "Default Locatie";
            this.StartDate = DateTime.Now;
            this.English = false;
        }
        public Research(string title, string? description, string? location, string? reward, string? status, Company company , Boolean english)
        {
            this.Title = title;
            this.Description = description;
            this.Location = location;
            this.Reward = Reward;
            this.Status = status;
            this.English = english;
            this.StartDate = DateTime.Now;
            this.Company = company;
            

        }
        public void AddNewSpecialist(Specialist specialist){
            Specialists.Add(specialist);
        }
    }
}
