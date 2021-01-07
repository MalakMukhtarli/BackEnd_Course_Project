using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BackEndFinalProject.DAL;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Hosting;
using BackEndFinalProject.Extensions;
using System.IO;
using BackEndFinalProject.Helpers;
using BackEndFinalProject.ViewModel;

namespace BackEndFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoursesController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET: Admin/Courses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Courses.Where(c => c.IsDeleted == false).ToListAsync());
        }
        // GET: Admin/Courses/Detail/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            var course = await _context.Courses.Where(c => c.IsDeleted == false).Include(cd => cd.CourseDetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null) return NotFound();
            return View(course);
        }
        // GET: Admin/Courses/Create
        public async Task<IActionResult> Create()
        {
            CourseCategoryVM courseCategory = new CourseCategoryVM
            {
                Course = _context.Courses.Where(c => !c.IsDeleted).Include(cd => cd.CourseDetail).FirstOrDefault(),
                CategoriesView = _context.Categories.Where(c => !c.IsDeleted).ToList()
            };
            return View(courseCategory);
        }
        // POST: Admin/Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseCategoryVM courseCategoryVM)
        {
            var categories = courseCategoryVM.CategoriesView = _context.Categories.Where(c =>c.IsDeleted==false).ToList();
            if (courseCategoryVM.Categories == null)
            {
                ModelState.AddModelError("", "Category bosh ola bilmez");
                return View(courseCategoryVM);
            }
            if (courseCategoryVM.Course.Photo == null)
            {
                ModelState.AddModelError("", "Shekil bosh ola bilmez");
                return View(courseCategoryVM);
            }
            //foreach (int ctg in courseCategoryVM.Categories)
            //{
            //    if (categories.Any(c => c.Id != ctg))
            //    {
            //        ModelState.AddModelError("", "Bele bir categoriya movcud deyil");
            //        return View(courseCategoryVM);
            //    }
            //}
            bool isExist = courseCategoryVM.Course.Photo.IsImage();
            if (!isExist)
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa shekil tipinde file sechin");
                return View(courseCategoryVM);
            }
            bool photoLength = courseCategoryVM.Course.Photo.PhotoLength(200);
            if (!photoLength)
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa sheklin olchusu 200kb kechmesin");
                return View(courseCategoryVM);
            }
            string folder = Path.Combine("assets", "img", "course");
            courseCategoryVM.Course.Image = await courseCategoryVM.Course.Photo.AddImageAsync(_env.WebRootPath, folder);
            courseCategoryVM.Course.IsDeleted = false;
            foreach (var item in courseCategoryVM.Categories)
            {
                courseCategoryVM.CategoryCourses.CategoryId = item;
                courseCategoryVM.CategoryCourses.CourseId = courseCategoryVM.Course.Id;
            }
            await _context.CategoryCourses.AddAsync(courseCategoryVM.CategoryCourses);
            await _context.Courses.AddAsync(courseCategoryVM.Course);
            await _context.SaveChangesAsync();
            //NotifyUserWithMail($"/Course/Detail/{courseCategoryVM.Course.Id}");
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Courses/Update/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            var course = await _context.Courses.Where(c => c.IsDeleted == false)
                .Include(cd => cd.CourseDetail).FirstOrDefaultAsync(c => c.Id == id);
            if (course == null) return NotFound();
            ViewBag.Ctg = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            return View(course);
        }

        // POST: Admin/Courses/Update/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Course course)
        {
            ViewBag.Ctg = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            if (id == null) return NotFound();
            if (id != course.Id) return NotFound();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (course.Photo != null)
            {
                bool isExist = course.Photo.IsImage();
                if (!isExist)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa shekil tipinde file sechin");
                    return View();
                }
                bool photoLength = course.Photo.PhotoLength(200);
                if (!photoLength)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa sheklin olchusu 200kb kechmesin");
                    return View();
                }
            }
            Course CourseSelected = _context.Courses.Where(c => c.IsDeleted == false)
                .Include(c => c.CourseDetail).FirstOrDefault(c => c.Id == id);
            if (CourseSelected == null) return NotFound();
            CourseSelected.Name = course.Name;
            CourseSelected.Description = course.Description;
            CourseSelected.CourseDetail.CourseAbout = course.CourseDetail.CourseAbout;
            CourseSelected.CourseDetail.HowToApply = course.CourseDetail.HowToApply;
            CourseSelected.CourseDetail.Certification = course.CourseDetail.Certification;
            CourseSelected.CourseDetail.CourseStartDate = course.CourseDetail.CourseStartDate;
            CourseSelected.CourseDetail.CourseDuration = course.CourseDetail.CourseDuration;
            CourseSelected.CourseDetail.ClassDuration = course.CourseDetail.ClassDuration;
            CourseSelected.CourseDetail.SkillLevel = course.CourseDetail.SkillLevel;
            CourseSelected.CourseDetail.Language = course.CourseDetail.Language;
            CourseSelected.CourseDetail.StudentsCount = course.CourseDetail.StudentsCount;
            CourseSelected.CourseDetail.Assessment = course.CourseDetail.Assessment;
            CourseSelected.CourseDetail.Price = course.CourseDetail.Price;

            if (course.Photo != null)
            {
                string folder = Path.Combine("assets", "img", "course");
                CourseSelected.Image = await course.Photo.AddImageAsync(_env.WebRootPath, folder);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var course = await _context.Courses.Where(c => c.IsDeleted == false)
                .Include(c => c.CourseDetail).FirstOrDefaultAsync(c => c.Id == id);
            if (course == null) return NotFound();
            return View(course);
        }

        // POST: Admin/Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            var course = await _context.Courses.Where(c => c.IsDeleted == false)
                .Include(c => c.CourseDetail).FirstOrDefaultAsync(c => c.Id == id);
            if (course == null) return NotFound();
            course.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //mail yollamaq uchun
        private async void NotifyUserWithMail(string controllerRoute)
        {
            var subscriber = _context.Subscribers.ToList().Select(x => x.Email);
            var linkAdress = $"{Request.Scheme}://{Request.Host}{Request.PathBase}{controllerRoute}";

            await EmailHelper.SendEmailToAllAsync(subscriber, "New event added!", linkAdress);
        }
    }
}
