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
    public class BlogViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public BlogViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? take)
        {
            List<Blog> blogs = _context.Blogs.Where(c => c.IsDeleted == false).Include(c => c.BlogDetail).Take((int)take).ToList();
            return View(await Task.FromResult(blogs));
        }
    
    }
}
