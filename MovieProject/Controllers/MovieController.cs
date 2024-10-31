using Microsoft.AspNetCore.Mvc;
using MovieProject.Models;

namespace MovieProject.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext MovieContext { get; set; }

        public MovieController(MovieContext ctx)
        {
            MovieContext = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add Movie";
            return View("Edit", new Movie());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit Movie";
            var movie = MovieContext.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie model)
        {
            MovieContext.Movies.Remove(model);
            MovieContext.SaveChanges();
            return RedirectToAction("Index" , "Home");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = MovieContext.Movies.Find(id);
            return View(movie);
        }



        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.MovieId == 0)
                {
                    MovieContext.Movies.Add(movie);
                }
                else
                {
                    MovieContext.Movies.Update(movie);
                }
                MovieContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (movie.MovieId == 0) ? "Add" : "Edit";
                return View(movie);
            }
           
        }

    }
}
