using Microsoft.AspNetCore.Mvc;
using MovieProject.Models;
using System.Diagnostics;

namespace MovieProject.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;

        public HomeController(MovieContext ctc) { 
        
            _context = ctc;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var movies = _context.Movies.OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}
