using FlyCraiovaSE.Data;
using FlyCraiovaSE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlyCraiovaSE.Controllers
{
    public class PlanesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PlanesController(ApplicationDbContext db)
        {
            _db = db;
        }
        [Authorize]
        public IActionResult Index()
        {
            List<Plane> objPlaneList = _db.Planes.ToList();

            return View(objPlaneList);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Plane obj)
        {
            _db.Planes.Add(obj);
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

            Plane? plane = _db.Planes.Find(id);

            if (plane == null)
            {
                return NotFound();
            }

            return View(plane);
        }

        [HttpPost]
        public IActionResult Edit(Plane obj)
        {
            _db.Planes.Update(obj);
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

            Plane? plane = _db.Planes.Find(id);

            if (plane == null)
            {
                return NotFound();
            }

            return View(plane);
        }

        [HttpPost]
        public IActionResult Delete(Plane obj)
        {
            _db.Planes.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
