using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Cuisine
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Country { get; set; }
        public string ImgURL { get; set; }
        public int Count {get;set;}
        public int Id { get; set; }
    }
}