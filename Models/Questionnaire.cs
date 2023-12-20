using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WPR.Models
{
    public class Questionnaire
    {
        [Key]
        public int QuestionnaireId { get; private set; }

        public string Title { get; set; }
        public string Description { get; set; }
        
        [JsonIgnore]
        public Company Company { get;set; }
        
        [JsonIgnore]
        public string CreationDate { get; set; }

    }
}
