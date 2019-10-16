using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
    public class BestRestaurantsContext : DbContext
    {   
        public virtual DbSet<Cuisine> Cuisine { get; set; } 
        // public DbSet<Restaurant> Restaurants { get; set; }

        public BestRestaurantsContext(DbContextOptions options) : base(options) { }
    }
} 