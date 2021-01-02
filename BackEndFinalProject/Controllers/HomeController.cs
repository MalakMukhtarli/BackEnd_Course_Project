using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using BackEndFinalProject.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
        public IActionResult Search(string search)
        {
            IEnumerable<Event> events = _context.Events.Where(e => e.IsDeleted == false && e.Title.Contains(search))
                .OrderByDescending(e => e.Id).Take(8);
            IEnumerable<Teacher> teachers = _context.Teachers.Where(t => t.IsDeleted == false && (t.Name.Contains(search) || t.Surname.Contains(search)))
                 .OrderByDescending(t => t.Id).Take(8);
            IEnumerable<Course> courses = _context.Courses.Where(c => c.IsDeleted == false && c.Name.Contains(search))
                .OrderByDescending(c => c.Id).Take(8);
            IEnumerable<Blog> blogs = _context.Blogs.Where(b => b.IsDeleted == false && b.Title.Contains(search))
                .OrderByDescending(b => b.Id).Take(8);
           
            HomeVM homeVM = new HomeVM
            {
                Events=events,
                Teachers=teachers,
                Courses=courses,
                Blogs=blogs
            };
            return PartialView("_SearchHomePartial", homeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
