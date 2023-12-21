using System;
using Microsoft.EntityFrameworkCore;

namespace WPR
{
    public class Location
	{
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public string HouseNumber { get; set; }
        public string Place { get; set; }
    }
}

