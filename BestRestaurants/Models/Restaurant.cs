using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Restaurant
    {
        public int RestaurantId {get;set;}        
        public string Name { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public string PriceRange { get; set; }
        public int CuisineId {get;set;}
    }

    public class Address
    {
        public string Street { get; set ;}
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}