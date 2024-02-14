using Microsoft.AspNetCore.Mvc;
using Mission6_Takaku.Models;
using System.Diagnostics;

//This is home controller
namespace Mission6_Takaku.Controllers
{
    //this class is connecting controller model
    public class HomeController : Controller
    {
        private MovieCollectionContext _context; //set _context
        public HomeController(MovieCollectionContext temp) // Constructor
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
            return View();
        }

        //This is a page after they submit the record by post method
        [HttpPost]

        //This action add response from input and save them. Also, it brings user to Confirmation view page.
        public IActionResult MovieCollection(Collection response)
        {
            _context.Collection.Add(response);
            _context.SaveChanges();

            return View("Confirmation");
        }
    }
}
