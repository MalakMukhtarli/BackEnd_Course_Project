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
        public IActionResult Search(string search)
        {
            IEnumerable<Blog> model = _context.Blogs.Where(b => b.IsDeleted == false && b.Title.Contains(search))
                .OrderByDescending(b => b.Id).Take(8);
            return PartialView("_SearchBlogPartial", model);
        }
        public IActionResult Select(int? id)
        {
            if (id == null) return NotFound();
            List<CategoryBlog> coursesBlog = _context.CategoryBlogs.Include(x => x.Blog)
                .Where(x => x.CategoryId == id).ToList();
            if (coursesBlog == null) return NotFound();
            List<Blog> blogs = coursesBlog.Select(x => x.Blog).Where(c => c.IsDeleted == false).ToList();
            if (blogs == null) return NotFound();

            return View("~/Views/Shared/Components/Blog/Default.cshtml", blogs);
        }
    }
}
