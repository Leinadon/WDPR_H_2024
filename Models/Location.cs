using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WPR
{
    [Table("Locations")]
    public class Location
	{
        [Key]
        public int Id {get; set;}
        [Required][StringLength(256, MinimumLength = 2)]
        public string StreetName { get; set; }
        [Required][StringLength(6, MinimumLength = 6)]
        public string PostalCode { get; set; }
        [Required][StringLength(10, MinimumLength = 1)]
        public string HouseNumber { get; set; }
        [Required][StringLength(64, MinimumLength = 2)]
        public string Place { get; set; }
        public int? SpecialistID{get; set;}
        
        public Specialist? specialist{get; set;}
        public int? CompanyID{get; set;}
        [ForeignKey(nameof(CompanyID))]
        public Company? Company{get; set;}
        public Location(){}
    }
}

