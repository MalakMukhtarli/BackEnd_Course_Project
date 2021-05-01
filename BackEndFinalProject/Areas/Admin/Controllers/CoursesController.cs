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
using Microsoft.AspNetCore.Authorization;

namespace BackEndFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
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
        public IActionResult Create()
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

            foreach (int ctg in courseCategoryVM.Categories)
            {
                if (!(categories.Any(c => c.Id == ctg)))
                {
                    ModelState.AddModelError("", "Bele bir categoriya movcud deyil");
                    return View(courseCategoryVM);
                }
            }

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

            await _context.Courses.AddAsync(courseCategoryVM.Course);

            await _context.SaveChangesAsync();

            List<CategoryCourse> viewModel = new List<CategoryCourse>();
            foreach (var ctgId in courseCategoryVM.Categories)
            {
                viewModel.Add(new CategoryCourse
                {
                    CourseId = courseCategoryVM.Course.Id,
                    CategoryId = ctgId
                });
            }
            foreach (var item in viewModel)
            {
                await _context.CategoryCourses.AddAsync(item);
            }

            await _context.SaveChangesAsync();
            //NotifyUserWithMail($"/Course/Detail/{courseCategoryVM.Course.Id}");
            return RedirectToAction(nameof(Index));
        }

        // GET: Admin/Courses/Update/5
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _context.Courses.Where(c => c.IsDeleted == false).Include(cd => cd.CourseDetail)
                .Include(cc => cc.CategoryCourses).ThenInclude(c => c.Category).FirstOrDefaultAsync(c => c.Id == id);

            if (course == null) return NotFound();
            List<int> ctgId = new List<int>();
            foreach (CategoryCourse ctgCrs in course.CategoryCourses)
            {
                ctgId.Add(ctgCrs.CategoryId);
            }
            CourseCategoryVM courseCategoryVM = new CourseCategoryVM
            {
                Course = course,
                Categories = ctgId,
                CategoriesView = _context.Categories.Where(c => c.IsDeleted == false).ToList()
            };
            //ViewBag.Ctg = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            return View(courseCategoryVM);
        }

        // POST: Admin/Courses/Update/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, CourseCategoryVM courseCategoryVM)
        {
            //ViewBag.Ctg = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync();
            var categories = courseCategoryVM.CategoriesView = _context.Categories.Where(c => c.IsDeleted == false).ToList();
            if (id == null) return NotFound();
            
            if (!ModelState.IsValid)
            {
                return View(courseCategoryVM);
            }
            Course CourseSelected = _context.Courses.Where(c => c.IsDeleted == false).Include(cd => cd.CourseDetail)
                .Include(cc => cc.CategoryCourses).ThenInclude(c => c.Category).FirstOrDefault(c => c.Id == id);
            if (CourseSelected == null) return NotFound();

            if (courseCategoryVM.Course.Photo != null)
            {
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
            }
            CourseSelected.Name = courseCategoryVM.Course.Name;
            CourseSelected.Description = courseCategoryVM.Course.Description;
            CourseSelected.CourseDetail.CourseAbout = courseCategoryVM.Course.CourseDetail.CourseAbout;
            CourseSelected.CourseDetail.HowToApply = courseCategoryVM.Course.CourseDetail.HowToApply;
            CourseSelected.CourseDetail.Certification = courseCategoryVM.Course.CourseDetail.Certification;
            CourseSelected.CourseDetail.CourseStartDate = courseCategoryVM.Course.CourseDetail.CourseStartDate;
            CourseSelected.CourseDetail.CourseDuration = courseCategoryVM.Course.CourseDetail.CourseDuration;
            CourseSelected.CourseDetail.ClassDuration = courseCategoryVM.Course.CourseDetail.ClassDuration;
            CourseSelected.CourseDetail.SkillLevel = courseCategoryVM.Course.CourseDetail.SkillLevel;
            CourseSelected.CourseDetail.Language = courseCategoryVM.Course.CourseDetail.Language;
            CourseSelected.CourseDetail.StudentsCount = courseCategoryVM.Course.CourseDetail.StudentsCount;
            CourseSelected.CourseDetail.Assessment = courseCategoryVM.Course.CourseDetail.Assessment;
            CourseSelected.CourseDetail.Price = courseCategoryVM.Course.CourseDetail.Price;

            if (courseCategoryVM.Course.Photo != null)
            {
                string folder = Path.Combine("assets", "img", "course");
                CourseSelected.Image = await courseCategoryVM.Course.Photo.AddImageAsync(_env.WebRootPath, folder);
            }

            foreach (int ctg in courseCategoryVM.Categories)
            {
                if (!(categories.Any(c => c.Id == ctg)))
                {
                    ModelState.AddModelError("", "Bele bir categoriya movcud deyil");
                    return View(courseCategoryVM);
                }
            }
            await _context.SaveChangesAsync();
            List<int> ctgId = new List<int>();
            foreach (CategoryCourse ctgCrs in CourseSelected.CategoryCourses)
            {
                ctgId.Add(ctgCrs.CategoryId);
            }
            ctgId = courseCategoryVM.Categories;
            //CourseCategoryVM courseCategoryVM = new CourseCategoryVM
            //{
            //    Course = course,
            //    Categories = ctgId
            //};
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
