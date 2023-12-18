using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WPR.Models
{
    public class Questionnaire
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        
        [JsonIgnore]
        public Company Company { get;set; }
        
        [JsonIgnore]
        public string CreationDate { get; set; }

    }
}
