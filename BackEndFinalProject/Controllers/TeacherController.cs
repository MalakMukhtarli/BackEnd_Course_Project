using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.AllTeacherCount = _context.Teachers.Count();
            return View(_context.Teachers.Where(t=>t.IsDeleted==false).ToList());
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = _context.Teachers.Where(t => t.IsDeleted == false).Include(td => td.TeacherDetail).FirstOrDefault(t => t.Id == id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }
        public IActionResult Search(string search)
        {
            IEnumerable<Teacher> model = _context.Teachers.Where(t => t.IsDeleted == false && (t.Name.Contains(search) || t.Surname.Contains(search)))
                .OrderByDescending(t => t.Id).Take(8);
            return PartialView("_SearchTeacherPartial", model);
        }
    }
}
