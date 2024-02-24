using Microsoft.AspNetCore.Mvc;
using Mission6_Johnson.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Mission6_Johnson.Controllers
{
    public class HomeController : Controller
    {

        private AddMoviesContext _context;

        public HomeController(AddMoviesContext temp) //constructor
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(Movie response)
        {
            _context.Movies.Add(response); //add record to the database
            _context.SaveChanges();
            return View("Confirmation", response);
        }

    }
}