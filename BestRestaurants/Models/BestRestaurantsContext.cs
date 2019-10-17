using Microsoft.EntityFrameworkCore;
using BestRestaurants.Models;

namespace BestRestaurants.Models
{
    public class BestRestaurantsContext : DbContext
    {
        public virtual DbSet<Cuisine> Cuisine { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }

        public virtual DbSet<Review> Reviews {get;set;}

        public BestRestaurantsContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}