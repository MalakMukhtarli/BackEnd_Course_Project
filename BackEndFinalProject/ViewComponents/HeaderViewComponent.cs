using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public HeaderViewComponent(AppDbContext context,
                                   UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.UserFullname = String.Empty;
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.UserFullname = (await _userManager.FindByNameAsync(User.Identity.Name)).Name + " " +
                    (await _userManager.FindByNameAsync(User.Identity.Name)).Surname;
            }
            Bio header = _context.Bios.FirstOrDefault();
            return View(await Task.FromResult(header));
        }
    }
}
