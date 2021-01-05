using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace BackEndFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;
        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }
        // GET: Admin/Categories
        public IActionResult Index()
        {
            return View(_context.Categories.Where(c => c.IsDeleted == false).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return NotFound();
            bool isExist = _context.Categories.Where(c => c.IsDeleted == false).Any(c => c.Name.ToLower() == category.Name.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", "Eyni adda bashqa categoriya movcuddur..");
                return View();
            }
            category.IsDeleted = false;
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Category category = _context.Categories.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Category category = _context.Categories.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            category.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Category category = _context.Categories.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Category category)
        {
            if (id == null) return NotFound();
            if (!ModelState.IsValid) return NotFound();
            Category categorySelected = await _context.Categories.FindAsync(id);
            Category isExist = _context.Categories.Where(c => c.IsDeleted == false)
                .FirstOrDefault(c => c.Name.ToLower() == category.Name.ToLower());
            if (isExist != null)
            {
                if (isExist.Id != categorySelected.Id)
                {
                    ModelState.AddModelError("Name", "Eyni adda bashqa categoriya movcuddur..");
                    return View();
                }
            }
            categorySelected.Name = category.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
