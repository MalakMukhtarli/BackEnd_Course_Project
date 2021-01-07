using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SubscribeController : Controller
    {
        private readonly AppDbContext _context;
        public SubscribeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Subscribers.ToList());
        }
        public async Task<IActionResult> Activated(int? id)
        {
            if (id == null) return NotFound();
            Subscribe email = await _context.Subscribers.FindAsync(id);
            if (email == null) return NotFound();
            return View(email);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Activated")]
        public async Task<IActionResult> ActivatedPost(int? id)
        {
            if (id == null) return NotFound();
            Subscribe email = await _context.Subscribers.FindAsync(id);
            if (email == null) return NotFound();

            if (email.IsDeleted)
            {
                email.IsDeleted = false;
            }
            else
            {
                email.IsDeleted = true;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
