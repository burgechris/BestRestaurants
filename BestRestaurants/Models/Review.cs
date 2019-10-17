using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Review
    {
        public int Id {get;set;}
        public string UserName { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }    
        public int RestaurantId {get;set;}
    }
}
