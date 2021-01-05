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
        public IActionResult Search(string search)
        {
            IEnumerable<Course> model = _context.Courses.Where(c => c.Name.Contains(search)).OrderByDescending(p => p.Id).Take(8);
            return PartialView("_SearchCoursePartial", model);
        }
        public IActionResult Select(int? id)
        {
            if (id == null) return NotFound();
            List<CategoryCourse> coursesCategory = _context.CategoryCourses.Include(x => x.Course)
                .Where(x => x.CategoryId == id).ToList();
            if (coursesCategory == null) return NotFound();
            List<Course> courses = coursesCategory.Select(x => x.Course).Where(c => c.IsDeleted==false).ToList();
            if (courses == null) return NotFound();

            return View("~/Views/Shared/Components/Course/Default.cshtml", courses);
        }
    }
}
