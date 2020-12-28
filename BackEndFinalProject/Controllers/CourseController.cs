using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using BackEndFinalProject.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
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
            Course courses = _context.Courses.Where(c => c.IsDeleted == false)
                .Include(cd => cd.CourseDetail).FirstOrDefault(c => c.Id == id);
            if (courses == null) return NotFound();

            return View(courses);
        }
    }
}
