using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            List<double> ratingModel = new List<double>();
            foreach(Restaurant r in restaurantModel)
            {
                double avg = _db.Reviews.Where(x => x.RestaurantId == r.RestaurantId).Average(y => y.Rating);
                ratingModel.Add(avg);
            }
            ViewBag.cuisine = cuisineModel;
            ViewBag.restaurants = restaurantModel;
            ViewBag.rating = ratingModel;
            return View();
        }

        [HttpGet("cuisine/{cuisineId}/restaurant/{Id}")]

        public ActionResult Restaurant(int cuisineId, int Id)
        {
            Restaurant restaurantModel = _db.Restaurants.FirstOrDefault(r => r.RestaurantId == Id) as Restaurant;
            List<Review> reviewModel = _db.Reviews.Where(rv => rv.RestaurantId == Id).ToList();
            double ratingModel = _db.Reviews.Where(rv => rv.RestaurantId == Id).Average(y => y.Rating);
            ViewBag.restaurant = restaurantModel;
            ViewBag.reviews = reviewModel;
            ViewBag.rating = ratingModel;
            return View();
        }
    }
}