using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Review
    {
        public string UserName { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }    
        public int RestaurantId {get;set;}
    }
}
