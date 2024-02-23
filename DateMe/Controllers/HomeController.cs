using Mission06_Nance.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();
            return View("AddMovie", new Application()); //create new application to get rid of the error that says " is not a valid input

        }
        [HttpPost]
        public IActionResult AddMovie(Application response)
        {
            //Checks to see if the infor is valid based on the model before updating the data
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //Add record to database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else //Invalid data
            {

                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

                return View(response);
            }

            
        }

        public IActionResult Read()
        {

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

            //Linq
            var applications = _context.Movies.Include("Category")
                .Where(x => x.Title != null)
                .OrderBy(x => x.MovieId).ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int id) //Edits selected record
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

                return View("AddMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Application updatedInfo)
        {
            if (ModelState.IsValid) // Check if the model state is valid
            {
                _context.Update(updatedInfo);
                _context.SaveChanges();

                return RedirectToAction("Read");
            }
            else // Model state is not valid, return to the view with the current information
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.Category)
                    .ToList();

                return View("AddMovie", updatedInfo); // Use the same AddMovie view for editing, ensuring validation messages are displayed
            }
        }


        [HttpGet]
        public IActionResult Delete(int id) //Deletes selected record
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]

        public IActionResult Delete(Application application)
        {
            _context.Movies.Remove(application);
            _context.SaveChanges();

            return RedirectToAction("Read");
        }
    }
}
