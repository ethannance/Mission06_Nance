using Mission06_Nance.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mission06_Nance.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _context;
        public HomeController(MoviesContext temp) //Constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(Application response)
        {
            _context.Applications.Add(response); //Add record to database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

    }
}
