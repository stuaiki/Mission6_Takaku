using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6_Takaku.Models;
using System.Diagnostics;
using System.Linq;

//This is home controller
namespace Mission6_Takaku.Controllers
{
    //this class is connecting controller model
    public class HomeController : Controller
    {
        private JoelHiltonMovieCollection _context; //set _context
        public HomeController(JoelHiltonMovieCollection temp) // Constructor
        {
            _context = temp;
        }

        //This action bring user to Index page.
        public IActionResult Index()
        {
            return View();
        }

        //This action brings uset to GetToKnow view page
        public IActionResult GetToKnow()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        //This action brings user to Quick Wits website using a url in Redirect()
        public IActionResult QuickWits()
        {
            return Redirect("https://www.qwcomedy.com");
        }

        //This action brings user to baconsale website using a url in Redirect()
        public IActionResult baconSale()
        {
            return Redirect("https://baconsale.com/");
        }

        //This is a default for MovieCollection View
        [HttpGet]
        public IActionResult MovieCollection()
        {
            ViewBag.Category = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View(new Movie());
        }

        //This is a page after they submit the record by post method
        [HttpPost]

        //This action add response from input and save them. Also, it brings user to Confirmation view page.
        public IActionResult MovieCollection(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Confirmation");
            }
            else
            {
                ViewBag.Category = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();

                return View(response);
            }
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies.Include("Category").ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Category = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("MovieCollection", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie UpdatedInfo)
        {
            _context.Update(UpdatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movies)
        {
            _context.Movies.Remove(movies);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
