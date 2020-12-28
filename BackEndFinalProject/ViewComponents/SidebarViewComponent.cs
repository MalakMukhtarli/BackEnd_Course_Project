using BackEndFinalProject.DAL;
using BackEndFinalProject.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.ViewComponents
{
    public class SidebarViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public SidebarViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            SidebarVM sidebarVM = new SidebarVM
            {
                Categories = _context.Categories.ToList(),
                Blogs = _context.Blogs.Where(b => b.IsDeleted == false).OrderByDescending(b => b.Id).Take(3).ToList()
            };
            return View(await Task.FromResult(sidebarVM));
        }
    }
}
