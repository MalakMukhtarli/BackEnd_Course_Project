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
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            int? page = ViewBag.Page;
            if (page == null)
            {
                List<Blog> blogs = _context.Blogs.Where(b => b.IsDeleted == false).Take(take).ToList();
                return View(await Task.FromResult(blogs));
            }
            List<Blog> blogs2 = _context.Blogs.Where(b=>b.IsDeleted==false).Skip(((int)page - 1) * take).Take(take).ToList();
            return View(await Task.FromResult(blogs2));
        }
    }
}
