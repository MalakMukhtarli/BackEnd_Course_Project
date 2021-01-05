using BackEndFinalProject.DAL;
using BackEndFinalProject.Extensions;
using BackEndFinalProject.Helpers;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            ViewBag.SliderCount = _context.Sliders.Count();
            return View(_context.Sliders.ToList());
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        // GET: Slider/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Slider/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            #region File
            if (slider.Photo == null || slider.Title == null || slider.Subtitle == null)
            {
                ModelState.AddModelError("", "Butun xanalari doldurun");
                return View(slider);
            }
            bool isExist = slider.Photo.IsImage();
            if (!isExist)
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa shekil tipinde file sechin");
                return View(slider);
            }
            bool photoLength = slider.Photo.PhotoLength(200);
            if (!photoLength)
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa sheklin olchusu 200kb kechmesin");
                return View(slider);
            }
            int sliderCount = _context.Sliders.Count();
            if (sliderCount >= 5)
            {
                ModelState.AddModelError("", "5den artiq shekil yukleye bilmersiniz");
                return View(slider);
            }

            string folder = Path.Combine("assets", "img", "slider");
            slider.Image = await slider.Photo.AddImageAsync(_env.WebRootPath, folder);
            await _context.Sliders.AddAsync(slider);

            #endregion
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Slider/Update/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        // POST: Slider/Update/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Slider slider)
        {
            if (id == null) return NotFound();
            Slider SliderSelected = await _context.Sliders.FindAsync(id);
            if (SliderSelected == null) return NotFound();
            if (slider.Photo == null && slider.Title == null && slider.Subtitle == null)
            {
                ModelState.AddModelError("", "Yenilenecek data tapilmadi");
                return View();
            }
            if (slider.Photo != null)
            {
                bool isExist = slider.Photo.IsImage();
                if (!isExist)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa shekil tipinde file sechin");
                    return View();
                }
                bool photoLength = slider.Photo.PhotoLength(200);
                if (!photoLength)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa sheklin olchusu 200kb kechmesin");
                    return View();
                }
                string folder = Path.Combine("assets", "img", "slider");
                bool isDeleted = Helper.DeletedPhoto(_env.WebRootPath, folder, SliderSelected);
                if (!isDeleted)
                {
                    ModelState.AddModelError("Photo", "Sistemde bash veren bir problemle bagli file siline bilmedi");
                    return View();
                }
                SliderSelected.Image = await slider.Photo.AddImageAsync(_env.WebRootPath, folder);
            }
             
            if (slider.Title != null)
            {
                SliderSelected.Title = slider.Title;
            }
            if (slider.Subtitle != null)
            {
                SliderSelected.Subtitle = slider.Subtitle;
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Slider/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            int sliderCount = _context.Sliders.Count();
            if (sliderCount <= 1)
            {
                ModelState.AddModelError("", "Sonuncu slideri sile bilmersiniz!");
                return View(slider);
            }
            return View(slider);
        }

        // POST: Slider/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            int sliderCount = _context.Sliders.Count();
            if (sliderCount <= 1)
            {
                ModelState.AddModelError("", "Sonuncu slideri sile bilmersiniz!");
                return View(slider);
            }
            _context.Sliders.Remove(slider);
            string folder = Path.Combine("assets", "img", "slider");
            bool isDeleted = Helper.DeletedPhoto(_env.WebRootPath, folder, slider);
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
