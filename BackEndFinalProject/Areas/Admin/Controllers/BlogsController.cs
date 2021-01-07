using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Hosting;
using BackEndFinalProject.Extensions;
using System.IO;

namespace BackEndFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogsController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        public BlogsController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: Admin/Blogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Blogs.Where(c => c.IsDeleted == false).ToListAsync());
        }

        // GET: Admin/Blogs/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            var blog = await _context.Blogs.Where(c => c.IsDeleted == false).Include(cd => cd.BlogDetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        // GET: Admin/Blogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (blog == null)
            {
                ModelState.AddModelError("", "Category bosh ola bilmez");
                return View(blog);
            }
            if (blog.Photo == null)
            {
                ModelState.AddModelError("", "Shekil bosh ola bilmez");
                return View(blog);
            }
            bool isExist = blog.Photo.IsImage();
            if (!isExist)
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa shekil tipinde file sechin");
                return View(blog);
            }
            bool photoLength = blog.Photo.PhotoLength(200);
            if (!photoLength)
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa sheklin olchusu 200kb kechmesin");
                return View(blog);
            }
            string folder = Path.Combine("assets", "img", "blog");
            blog.Image = await blog.Photo.AddImageAsync(_env.WebRootPath, folder);
            blog.IsDeleted = false;
            
            await _context.Blogs.AddAsync(blog);
            await _context.SaveChangesAsync();
            //NotifyUserWithMail($"/Course/Detail/{blog.Id}");
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Blogs/Update/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        // POST: Admin/Blogs/Update/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog)
        {
            if (id == null) return NotFound();
            if (id != blog.Id) return NotFound();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (blog.Photo != null)
            {
                bool isExist = blog.Photo.IsImage();
                if (!isExist)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa shekil tipinde file sechin");
                    return View();
                }
                bool photoLength = blog.Photo.PhotoLength(200);
                if (!photoLength)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa sheklin olchusu 200kb kechmesin");
                    return View();
                }
            }
            Blog BlogSelected = _context.Blogs.Where(c => c.IsDeleted == false)
                .Include(c => c.BlogDetail).FirstOrDefault(c => c.Id == id);
            if (BlogSelected == null) return NotFound();
            BlogSelected.Title = blog.Title;
            BlogSelected.ByName = blog.ByName;
            BlogSelected.AddedTime = blog.AddedTime;
            BlogSelected.BlogDetail.Description = blog.BlogDetail.Description;

            if (blog.Photo != null)
            {
                string folder = Path.Combine("assets", "img", "course");
                BlogSelected.Image = await blog.Photo.AddImageAsync(_env.WebRootPath, folder);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Blogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var blog = await _context.Blogs.Where(c => c.IsDeleted == false).Include(cd => cd.BlogDetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        // POST: Admin/Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            var blog = await _context.Blogs.Where(c => c.IsDeleted == false).Include(cd => cd.BlogDetail)
                .FirstOrDefaultAsync(cd => cd.Id==id);
            if (blog == null) return NotFound();
            blog.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.Id == id);
        }
    }
}
