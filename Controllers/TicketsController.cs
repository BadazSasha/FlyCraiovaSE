using FlyCraiovaSE.Data;
using FlyCraiovaSE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlyCraiovaSE.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TicketsController(ApplicationDbContext db)
        {
            _db = db;
        }
        [Authorize]
        public IActionResult Index()
        {
            List<Ticket> tickets = _db.Tickets.ToList();

            return View(tickets);
        }

        [Authorize(Roles = "User")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Ticket obj)
        {
            _db.Tickets.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "User")]
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Ticket? ticket = _db.Tickets.Find(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        [HttpPost]
        public IActionResult Delete(Ticket obj)
        {
            _db.Tickets.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
