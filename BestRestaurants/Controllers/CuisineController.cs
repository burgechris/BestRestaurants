using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Controllers
{
    public class CuisineController : Controller
    {
        private readonly BestRestaurantsContext _db;

        public CuisineController(BestRestaurantsContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Cuisine> model = _db.Cuisine.ToList();
            return View(model);
        }

        [HttpGet("cuisine/{Id}")]
        public ActionResult CuisineType(int id)
        {
            Cuisine cuisineModel = _db.Cuisine.FirstOrDefault(cuisine => cuisine.Id == id);
            List<Restaurant> restaurantModel = _db.Restaurants.Where(r => r.CuisineId == id).ToList();
            Dictionary<string,Object> model = new Dictionary<string,Object>(){
                {"cuisine", cuisineModel}, 
                {"restaurants", restaurantModel}
                };
            return View(model);
        }

        [HttpGet("cuisine/{cuisineId}/restuarant/{Id}")]

        public ActionResult Restaurant(int cuisineId, int Id)
        {
            Restaurant restaurantModel = _db.Restaurants.Where(r => r.Id == Id) as Restaurant;
            List<Review> reviewModel = _db.Reviews.Where(rv => rv.RestaurantId == Id).ToList();
            Dictionary<string, Object> model = new Dictionary<string, object>(){{"restaurant", restaurantModel},{"reviews", reviewModel};
            return View(model);
        }
    }
}