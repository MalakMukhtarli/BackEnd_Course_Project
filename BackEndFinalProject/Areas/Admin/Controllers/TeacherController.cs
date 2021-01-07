using BackEndFinalProject.DAL;
using BackEndFinalProject.Extensions;
using BackEndFinalProject.Helpers;
using BackEndFinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TeacherController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;
        public TeacherController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Teachers.Where(t=>t.IsDeleted==false).ToList());
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher =  _context.Teachers.Where(t=>t.IsDeleted==false).Include(t=>t.TeacherDetail).FirstOrDefault(t=>t.Id==id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }
        // GET: Teacher/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Teacher/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            #region File
            if (teacher.Photo == null)
            {
                ModelState.AddModelError("Photo", "Shekil bosh ola bilmez");
                return View(teacher);
            }
            bool isExist = teacher.Photo.IsImage();
            if (!isExist)
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa shekil tipinde file sechin");
                return View(teacher);
            }
            bool photoLength = teacher.Photo.PhotoLength(200);
            if (!photoLength)
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa sheklin olchusu 200kb kechmesin");
                return View(teacher);
            }

            string folder = Path.Combine("assets", "img", "teacher");
            teacher.Image = await teacher.Photo.AddImageAsync(_env.WebRootPath, folder);
            teacher.IsDeleted = false;
            await _context.Teachers.AddAsync(teacher);

            #endregion
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Teacher/Update/5
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = _context.Teachers.Where(t => t.IsDeleted == false).Include(t => t.TeacherDetail).FirstOrDefault(t => t.Id == id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }

        // POST: Teacher/Update/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Teacher teacher)
        {
            if (id == null) return NotFound();
            if (teacher.Photo != null)
            {
                bool isExist = teacher.Photo.IsImage();
                if (!isExist)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa shekil tipinde file sechin");
                    return View();
                }
                bool photoLength = teacher.Photo.PhotoLength(200);
                if (!photoLength)
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa sheklin olchusu 200kb kechmesin");
                    return View();
                }
            }
            Teacher TeacherSelected = _context.Teachers.Where(t => t.IsDeleted == false)
                .Include(t => t.TeacherDetail).FirstOrDefault(t => t.Id == id);
            if (TeacherSelected == null) return NotFound();
            if (teacher.Photo == null && TeacherSelected.Name==teacher.Name&&
                TeacherSelected.Surname==teacher.Surname&&TeacherSelected.Position==teacher.Position&&
                TeacherSelected.Facebook==teacher.Facebook&&TeacherSelected.Pinterest==teacher.Pinterest&&
                TeacherSelected.Twitter==teacher.Twitter&&TeacherSelected.Vimeo==teacher.Vimeo&&
                TeacherSelected.TeacherDetail.About==teacher.TeacherDetail.About&&
                TeacherSelected.TeacherDetail.Communication==teacher.TeacherDetail.Communication&&
                TeacherSelected.TeacherDetail.Degree==teacher.TeacherDetail.Degree&&
                TeacherSelected.TeacherDetail.Design==teacher.TeacherDetail.Design&&
                TeacherSelected.TeacherDetail.Development==teacher.TeacherDetail.Development&&
                TeacherSelected.TeacherDetail.Experience==teacher.TeacherDetail.Experience&&
                TeacherSelected.TeacherDetail.Faculty==teacher.TeacherDetail.Faculty&&
                TeacherSelected.TeacherDetail.Innovation==teacher.TeacherDetail.Innovation&&
                TeacherSelected.TeacherDetail.Language==teacher.TeacherDetail.Language&&
                TeacherSelected.TeacherDetail.Mail==teacher.TeacherDetail.Mail&&
                TeacherSelected.TeacherDetail.Phone==teacher.TeacherDetail.Phone&&
                TeacherSelected.TeacherDetail.Skype==teacher.TeacherDetail.Skype&&
                TeacherSelected.TeacherDetail.Hobbies==teacher.TeacherDetail.Hobbies&&
                TeacherSelected.TeacherDetail.TeamLeader==teacher.TeacherDetail.TeamLeader)
            {
                ModelState.AddModelError("", "Yenilenecek data tapilmadi");
                return View();
            }

            if (TeacherSelected.Name != teacher.Name)
            {
                TeacherSelected.Name = teacher.Name;
            }
            if (TeacherSelected.Surname != teacher.Surname)
            {
                TeacherSelected.Surname = teacher.Surname;
            }
            if (TeacherSelected.Position != teacher.Position)
            {
                TeacherSelected.Position = teacher.Position;
            }
            if (TeacherSelected.Facebook != teacher.Facebook)
            {
                TeacherSelected.Facebook = teacher.Facebook;
            }
            if (TeacherSelected.Pinterest != teacher.Pinterest)
            {
                TeacherSelected.Pinterest = teacher.Pinterest;
            }
            if (TeacherSelected.Twitter != teacher.Twitter)
            {
                TeacherSelected.Twitter = teacher.Twitter;
            }
            if (TeacherSelected.Vimeo != teacher.Vimeo)
            {
                TeacherSelected.Vimeo = teacher.Vimeo;
            }
            if (TeacherSelected.TeacherDetail.About != teacher.TeacherDetail.About)
            {
                TeacherSelected.TeacherDetail.About = teacher.TeacherDetail.About;
            }
            if (TeacherSelected.TeacherDetail.Communication != teacher.TeacherDetail.Communication)
            {
                TeacherSelected.TeacherDetail.Communication = teacher.TeacherDetail.Communication;
            }
            if (TeacherSelected.TeacherDetail.Degree != teacher.TeacherDetail.Degree)
            {
                TeacherSelected.TeacherDetail.Degree = teacher.TeacherDetail.Degree;
            }
            if (TeacherSelected.TeacherDetail.Design != teacher.TeacherDetail.Design)
            {
                TeacherSelected.TeacherDetail.Design = teacher.TeacherDetail.Design;
            }
            if (TeacherSelected.TeacherDetail.Development != teacher.TeacherDetail.Development)
            {
                TeacherSelected.TeacherDetail.Development = teacher.TeacherDetail.Development;
            }
            if (TeacherSelected.TeacherDetail.Experience != teacher.TeacherDetail.Experience)
            {
                TeacherSelected.TeacherDetail.Experience = teacher.TeacherDetail.Experience;
            }
            if (TeacherSelected.TeacherDetail.Faculty != teacher.TeacherDetail.Faculty)
            {
                TeacherSelected.TeacherDetail.Faculty = teacher.TeacherDetail.Faculty;
            }
            if (TeacherSelected.TeacherDetail.Innovation != teacher.TeacherDetail.Innovation)
            {
                TeacherSelected.TeacherDetail.Innovation = teacher.TeacherDetail.Innovation;
            }
            if (TeacherSelected.TeacherDetail.Language != teacher.TeacherDetail.Language)
            {
                TeacherSelected.TeacherDetail.Language = teacher.TeacherDetail.Language;
            }
            if (TeacherSelected.TeacherDetail.Mail != teacher.TeacherDetail.Mail)
            {
                TeacherSelected.TeacherDetail.Mail = teacher.TeacherDetail.Mail;
            }
            if (TeacherSelected.TeacherDetail.Phone != teacher.TeacherDetail.Phone)
            {
                TeacherSelected.TeacherDetail.Phone = teacher.TeacherDetail.Phone;
            }
            if (TeacherSelected.TeacherDetail.Skype != teacher.TeacherDetail.Skype)
            {
                TeacherSelected.TeacherDetail.Skype = teacher.TeacherDetail.Skype;
            }
            if (TeacherSelected.TeacherDetail.TeamLeader != teacher.TeacherDetail.TeamLeader)
            {
                TeacherSelected.TeacherDetail.TeamLeader = teacher.TeacherDetail.TeamLeader;
            }
            if (TeacherSelected.TeacherDetail.Hobbies != teacher.TeacherDetail.Hobbies)
            {
                TeacherSelected.TeacherDetail.Hobbies = teacher.TeacherDetail.Hobbies;
            }
            if (teacher.Photo != null)
            {
                string folder = Path.Combine("assets", "img", "teacher");
                TeacherSelected.Image = await teacher.Photo.AddImageAsync(_env.WebRootPath, folder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Teacher/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = _context.Teachers.Where(t => t.IsDeleted == false)
                .Include(t => t.TeacherDetail).FirstOrDefault(t => t.Id == id);
            if (teacher == null) return NotFound();
            
            return View(teacher);
        }

        // POST: Teacher/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = _context.Teachers.Where(t => t.IsDeleted == false)
                .Include(t => t.TeacherDetail).FirstOrDefault(t => t.Id == id);
            if (teacher == null) return NotFound();

            teacher.IsDeleted = true;
            teacher.DeletedTime = DateTime.Now;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
