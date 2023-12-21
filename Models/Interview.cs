namespace WPR
{
    public class Interview : Research{
        public List<Question> Questions = new List<Question>();
        public Specialist Specialist{get; set;}

        public Interview(string title, string description, string location, string reward, string status, Specialist specialist,Company company, Boolean english){
            this.Title = title;
            this.Description = description;
            this.Location = location;
            this.Reward = reward;
            this.Status = status;
            this.English = english;
            this.StartDate = DateTime.Now;
            this.Company = company;
            this.Specialist = specialist;
        }
        private void AddQuestion(string text){
            Question question = new Question(text, this);
            this.Questions.Add(question);
            
        }
    }
}
