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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? page = 1)
        {
            ViewBag.BlogCount = Decimal.Ceiling((decimal)_context.Blogs.Count() / 4);
            ViewBag.Page = page;
            return View();
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = _context.Blogs.Where(b => b.IsDeleted == false).Include(b => b.BlogDetail)
                .Include(bc => bc.CategoryBlogs).ThenInclude(c => c.Category).FirstOrDefault(b=>b.Id==id);
            if (blog == null) return NotFound();

            
            return View(blog);
        }
    }
}
