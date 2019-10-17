using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Restaurant
    {
        public int Id {get;set;}        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PriceRange { get; set; }
        public int CuisineId {get;set;}
    }
}