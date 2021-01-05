using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using BackEndFinalProject.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace BackEndFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class VideosController : Controller
    {
        private readonly AppDbContext _context;
        public VideosController(AppDbContext context)
        {
            _context = context;
        }
        // GET: Admin/Videos
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeVideos.ToListAsync());
        }
        // GET: Admin/Videos/Detail/1
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            HomeVideo homeVideo = await _context.HomeVideos.FirstOrDefaultAsync(m => m.Id == id);
            if (homeVideo == null) return NotFound();
            return View(homeVideo);
        }
        // GET: Admin/Videos/Update/1
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            var homeVideo = await _context.HomeVideos.FindAsync(id);
            if (homeVideo == null) return NotFound();
            return View(homeVideo);
        }
        // POST: Admin/Videos/Update/1
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,HomeVideo homeVideo)
        {
            if (id == null) return NotFound();
            if (id != homeVideo.Id) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeVideo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeVideoExists(homeVideo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(homeVideo);
        }

        private bool HomeVideoExists(int id)
        {
            return _context.HomeVideos.Any(e => e.Id == id);
        }
    }
}
