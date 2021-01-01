using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using FiorelloFrontToBack.Extensions;
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
        // GET: SliderController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SliderController/Create
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
    }
}
