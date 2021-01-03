using BackEndFinalProject.Extensions;
using BackEndFinalProject.Models;
using BackEndFinalProject.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndFinalProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.UserId = String.Empty;
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.UserId = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
            }
            List<AppUser> users = _userManager.Users.ToList();
            List<UserVM> usersVM = new List<UserVM>();
            foreach (AppUser user in users)
            {
                UserVM userVM = new UserVM
                {
                    Id = user.Id,
                    Name = user.Name,
                    Surname = user.Surname,
                    Email = user.Email,
                    Username = user.UserName,
                    IsDeleted = user.IsDeleted,
                    Role = (await _userManager.GetRolesAsync(user))[0]
                };

                usersVM.Add(userVM);
            }

            return View(usersVM);
        }

        public async Task<IActionResult> Activated(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            if (user.UserName == User.Identity.Name)
            {
                return Content("Bu sehifeye kecid ede bilmezsiniz!");
            }
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Activated")]
        public async Task<IActionResult> ActivatedPost(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (user.IsDeleted)
            {
                user.IsDeleted = false;
            }
            else
            {
                user.IsDeleted = true;
            }
            await _userManager.UpdateAsync(user);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ResetPassword(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(string id, CheckPasswordVM passwords)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (passwords == null)
            {
                ModelState.AddModelError("", "Xanalar bosh ola bilmez");
                return View();
            }
            if (user == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool chechPass = await _userManager.CheckPasswordAsync(user, passwords.OldPassword);

            if (!chechPass)
            {
                ModelState.AddModelError("", "Shifre sehvdir");
                return View();
            }

            IdentityResult identityResult = await _userManager.ChangePasswordAsync(user, passwords.OldPassword, passwords.NewPassword);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

            if (passwords.OldPassword == passwords.NewPassword)
            {
                ModelState.AddModelError("", "Yeni Shifreniz Kohne Shifrenizle eyni ola bilmez");
                return View();
            }

            string passToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            await _userManager.ResetPasswordAsync(user, passToken, passwords.NewPassword);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ChangeRole(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            if (user.UserName == User.Identity.Name)
            {
                return Content("Bu sehifeye kecid ede bilmezsiniz!");
            }
            UserVM userVM = await GetUserVMAsync(user);

            return View(userVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string id, string role)
        {
            if (id == null || role == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            IdentityResult addResult = await _userManager.AddToRoleAsync(user, role);
            if (!addResult.Succeeded)
            {
                ModelState.AddModelError("", "Emeliyyat ugursuz oldu,Sistemde her hansi bir problem bash verdi");
                UserVM userVM = await GetUserVMAsync(user);
                View(userVM);
            }
            string oldRole = (await _userManager.GetRolesAsync(user))[0];
            IdentityResult removeResult = await _userManager.RemoveFromRoleAsync(user, oldRole);
            if (!removeResult.Succeeded)
            {
                ModelState.AddModelError("", "Emeliyyat ugursuz oldu,Sistemde her hansi bir problem bash verdi");
                UserVM userVM = await GetUserVMAsync(user);
                View(userVM);
            }
            await _userManager.AddToRoleAsync(user, role);
            return RedirectToAction(nameof(Index));
        }
        private async Task<UserVM> GetUserVMAsync(AppUser user)
        {
            List<string> roles = new List<string>();
            foreach (var role in Enum.GetValues(typeof(Roles)))
            {
                roles.Add(role.ToString());
            }
            UserVM userVM = new UserVM
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Username = user.UserName,
                IsDeleted = user.IsDeleted,
                Role = (await _userManager.GetRolesAsync(user))[0],
                Roles = roles
            };
            return userVM;
        }
    }
}
