using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
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
    }
}