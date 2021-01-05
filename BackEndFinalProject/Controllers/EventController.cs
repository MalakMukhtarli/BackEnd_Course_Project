using BackEndFinalProject.DAL;
using BackEndFinalProject.Helpers;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Event evnt = _context.Events.Where(c => c.IsDeleted == false)
                .Include(cd => cd.EventDetail).FirstOrDefault(c => c.Id == id);
            if (evnt == null) return NotFound();

            return View(evnt);
        }
        public IActionResult Search(string search)
        {
            IEnumerable<Event> model = _context.Events.Where(e => e.IsDeleted == false && e.Title.Contains(search))
                .OrderByDescending(e => e.Id).Take(8);
            return PartialView("_SearchEventPartial", model);
        }
        public IActionResult Select(int? id)
        {
            if (id == null) return NotFound();
            List<CategoryEvent> coursesEvent = _context.CategoryEvents.Include(x => x.Event)
                .Where(x => x.CategoryId == id).ToList();
            if (coursesEvent == null) return NotFound();
            List<Event> events = coursesEvent.Select(x => x.Event).Where(c => c.IsDeleted == false).ToList();
            if (events == null) return NotFound();

            return View("~/Views/Shared/Components/Event/Default.cshtml", events);
        }
    }
}
