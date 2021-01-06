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
using Microsoft.AspNetCore.Hosting;
using BackEndFinalProject.Extensions;
using System.IO;
using BackEndFinalProject.Helpers;

namespace BackEndFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TestimonialsController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        public TestimonialsController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET: Admin/Testimonials
        public async Task<IActionResult> Index()
        {
            ViewBag.TestimonialCount = _context.Testimonials.Count();
            return View(await _context.Testimonials.ToListAsync());
        }
        // GET: Admin/Testimonials/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            var testimonial = await _context.Testimonials.FirstOrDefaultAsync(m => m.Id == id);
            if (testimonial == null) return NotFound();
            return View(testimonial);
        }
        // GET: Admin/Testimonials/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Admin/Testimonials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Testimonial testimonial)
        {
            if (testimonial.Photo == null || testimonial.Description == null || testimonial.FullName == null)
            {
                ModelState.AddModelError("", " * isharesi olan butun xanalari doldurun");
                return View(testimonial);
            }
            if (ModelState.IsValid)
            {
                bool isExist = testimonial.Photo.IsImage();
                if (!isExist)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa shekil tipinde file sechin");
                    return View(testimonial);
                }
                bool photoLength = testimonial.Photo.PhotoLength(200);
                if (!photoLength)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa sheklin olchusu 200kb kechmesin");
                    return View(testimonial);
                }
                int testimonialCount = _context.Testimonials.Count();
                if (testimonialCount >= 10)
                {
                    ModelState.AddModelError("", "10-dan artiq shekil yukleye bilmersiniz");
                    return View(testimonial);
                }

                string folder = Path.Combine("assets", "img", "testimonial");
                testimonial.Image = await testimonial.Photo.AddImageAsync(_env.WebRootPath, folder);
                await _context.Testimonials.AddAsync(testimonial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("", "Sistemde her hansi bir problem bash verdi");
            return View(testimonial);
        }

        // GET: Admin/Testimonials/Edit/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            var testimonial = await _context.Testimonials.FindAsync(id);
            if (testimonial == null) return NotFound();
            return View(testimonial);
        }

        // POST: Admin/Testimonials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Testimonial testimonial)
        {
            if (id == null) return NotFound();
            Testimonial TestimonialSelected = await _context.Testimonials.FindAsync(id);
            if (TestimonialSelected == null) return NotFound();
            if (testimonial.Photo == null && testimonial.Description == null && testimonial.FullName == null)
            {
                ModelState.AddModelError("", "Yenilenecek data tapilmadi");
                return View();
            }
            if (testimonial.Photo != null)
            {
                bool isExist = testimonial.Photo.IsImage();
                if (!isExist)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa shekil tipinde file sechin");
                    return View();
                }
                bool photoLength = testimonial.Photo.PhotoLength(200);
                if (!photoLength)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa sheklin olchusu 200kb kechmesin");
                    return View();
                }
                string folder = Path.Combine("assets", "img", "testimonial");
                bool isDeleted = Helper.DeletedPhotoTestimonial(_env.WebRootPath, folder, TestimonialSelected);
                if (!isDeleted)
                {
                    ModelState.AddModelError("Photo", "Sistemde bash veren bir problemle bagli file siline bilmedi");
                    return View();
                }
                TestimonialSelected.Image = await testimonial.Photo.AddImageAsync(_env.WebRootPath, folder);
            }

            if (testimonial.Description != null)
            {
                TestimonialSelected.Description = testimonial.Description;
            }
            if (testimonial.FullName != null)
            {
                TestimonialSelected.FullName = testimonial.FullName;
            }
            TestimonialSelected.Note = testimonial.Note;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Testimonials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var testimonial = await _context.Testimonials.FirstOrDefaultAsync(m => m.Id == id);
            if (testimonial == null) return NotFound();
            return View(testimonial);
        }

        // POST: Admin/Testimonials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            var testimonial = await _context.Testimonials.FindAsync(id);
            if (testimonial == null) return NotFound();
            int testimonialCount = _context.Testimonials.Count();
            if (testimonialCount <= 1)
            {
                ModelState.AddModelError("", "Sonuncu Testimonial-i sile bilmersiniz!");
                return View(testimonial);
            }
            _context.Testimonials.Remove(testimonial);
            string folder = Path.Combine("assets", "img", "testimonial");
            bool isDeleted = Helper.DeletedPhotoTestimonial(_env.WebRootPath, folder, testimonial);
            if (!isDeleted)
            {
                ModelState.AddModelError("", "Sistemde bash veren bir problemle bagli file siline bilmedi");
                return View();
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
