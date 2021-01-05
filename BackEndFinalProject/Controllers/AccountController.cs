using BackEndFinalProject.DAL;
using BackEndFinalProject.Extensions;
using BackEndFinalProject.Models;
using BackEndFinalProject.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signInManager,
                                 RoleManager<IdentityRole> roleManager,
                                 AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Subscribe(SubscribeVM model)
        {
            if (!ModelState.IsValid)
                return NotFound();

            var existingEmail = _context.Subscribers.Where(e=>e.IsDeleted==false).FirstOrDefault(x => x.Email == model.Email.Trim());

            if (existingEmail == null)
            {
                model.IsDeleted = false;
                var subscribeModel = new Subscribe
                {
                    Email = model.Email.Trim(),
                    IsDeleted=model.IsDeleted
                };
                _context.Subscribers.Add(subscribeModel);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByEmailAsync(login.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Email or password wrong!!!");
                return View();
            }

            if (user.IsDeleted)
            {
                ModelState.AddModelError("", "This account blocked!!!");
                return View();
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult =
                await _signInManager.PasswordSignInAsync(user, login.Password, true, true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Please,try few minutes later");
                return View(login);
            }

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password wrong!!!");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();

            AppUser newUser = new AppUser
            {
                Name = register.Name,
                Surname = register.Surname,
                UserName = register.UserName,
                Email = register.Email
            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(newUser, Roles.Simple.ToString());
            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        #region Create User Role
        //public async Task CreateUserRole()
        //{
        //    if (!(await _roleManager.RoleExistsAsync(Roles.Admin.ToString())))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Admin.ToString() });
        //    if (!(await _roleManager.RoleExistsAsync(Roles.Simple.ToString())))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Simple.ToString() });
        //    if (!(await _roleManager.RoleExistsAsync(Roles.CourseModerator.ToString())))
        //        await _roleManager.CreateAsync(new IdentityRole { Name = Roles.CourseModerator.ToString() });
        //}
        #endregion
    }
}
