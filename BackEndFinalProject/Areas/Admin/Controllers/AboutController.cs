using BackEndFinalProject.DAL;
using BackEndFinalProject.Extensions;
using BackEndFinalProject.Helpers;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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
    public class AboutController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Abouts.ToList());
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            About about = await _context.Abouts.FindAsync(id);
            if (about == null) return NotFound();
            return View(about);
        }
        // GET: About/Update/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            About about = await _context.Abouts.FindAsync(id);
            if (about == null) return NotFound();
            return View(about);
        }
        // POST: About/Update/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, About about)
        {
            if (id == null) return NotFound();
            About AboutSelected = await _context.Abouts.FindAsync(id);
            if (AboutSelected == null) return NotFound();
            if (about.Photo == null && about.Title == null && about.Content == null)
            {
                ModelState.AddModelError("", "Yenilenecek data tapilmadi");
                return View();
            }
            if (about.Photo != null)
            {
                bool isExist = about.Photo.IsImage();
                if (!isExist)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa shekil tipinde file sechin");
                    return View();
                }
                bool photoLength = about.Photo.PhotoLength(200);
                if (!photoLength)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa sheklin olchusu 200kb kechmesin");
                    return View();
                }
                string folder = Path.Combine("assets", "img", "about");
                bool isDeleted = Helper.DeletedPhotoAbout(_env.WebRootPath, folder, AboutSelected);
                if (!isDeleted)
                {
                    ModelState.AddModelError("Photo", "Sistemde bash veren bir problemle bagli file siline bilmedi");
                    return View();
                }
                AboutSelected.Image = await about.Photo.AddImageAsync(_env.WebRootPath, folder);
            }

            if (about.Title != null && about.Title!=AboutSelected.Title)
            {
                AboutSelected.Title = about.Title;
            }
            if (about.Content != null && about.Content != AboutSelected.Content)
            {
                AboutSelected.Content = about.Content;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
