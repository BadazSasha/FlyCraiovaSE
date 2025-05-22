using FlyCraiovaSE.Data;
using FlyCraiovaSE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlyCraiovaSE.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DestinationsController(ApplicationDbContext db)
        {
            _db = db;
        }
        [Authorize]
        public IActionResult Index(string sortOrder, string searchString)
        {
            // Store the current sort order and search filter in ViewBag
            ViewBag.CurrentSort = sortOrder;
            ViewBag.CurrentFilter = searchString;

            // Start with all destinations from the database
            var destinations = _db.Destinations.AsQueryable();

            // Filter by search string
            if (!string.IsNullOrEmpty(searchString))
            {
                destinations = destinations.Where(d =>
                    d.Title.Contains(searchString) || d.Description.Contains(searchString));
                // Only keep destinations where the title or description contains the search text
            }

            // Apply sorting
            destinations = sortOrder switch
            {
                "price_desc" => destinations.OrderByDescending(d => d.Price),
                _ => destinations.OrderBy(d => d.Price)
            };

            return View(destinations.ToList());
        }



        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Destination obj)
        {
            _db.Destinations.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Destination? destination = _db.Destinations.Find(id);

            if (destination == null)
            {
                return NotFound();
            }

            return View(destination);
        }

        [HttpPost]
        public IActionResult Edit(Destination obj)
        {
            _db.Destinations.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Destination? destination = _db.Destinations.Find(id);

            if (destination == null)
            {
                return NotFound();
            }

            return View(destination);
        }

        [HttpPost]
        public IActionResult Delete(Destination obj)
        {
            _db.Destinations.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
