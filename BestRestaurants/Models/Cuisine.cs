using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Cuisine
    {
        public Cuisine()
        {
            this.Restaurant = new HashSet<Restaurant>();
        }

        public string Name { get; set; }
        public string Description { get; set; } 
    }
}