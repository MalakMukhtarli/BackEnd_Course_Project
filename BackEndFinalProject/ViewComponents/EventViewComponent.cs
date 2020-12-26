using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.ViewComponents
{
    public class EventViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public EventViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Event> events = _context.Events.Where(c => c.IsDeleted == false).Include(c => c.EventDetail).Take(take).ToList();
            return View(await Task.FromResult(events));
        }
    }
}
