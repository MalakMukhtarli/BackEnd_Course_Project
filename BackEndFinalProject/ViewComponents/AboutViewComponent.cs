using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.ViewComponents
{
    public class AboutViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public AboutViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            About about = _context.Abouts.FirstOrDefault(a=>a.Id==id);
            return View(await Task.FromResult(about));
        }
    }
}
