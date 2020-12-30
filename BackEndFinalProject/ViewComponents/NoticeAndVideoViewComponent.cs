using BackEndFinalProject.DAL;
using BackEndFinalProject.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.ViewComponents
{
    public class NoticeAndVideoViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;
        public NoticeAndVideoViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            NoticeVM noticeVM = new NoticeVM
            {
                Notices = _context.Notices.Where(n => n.IsDeleted == false).OrderByDescending(n => n.AddedTime).ToList(),
                HomeVideo = _context.HomeVideos.FirstOrDefault()
            };
            return View(await Task.FromResult(noticeVM));
        }
    }
}
