using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _123.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using _123.Areas.Identity.Data;

namespace _123.Controllers
{
    public class HomeController : Controller
    {
        public UserManager<TableUser> userManager;

        public HomeController(UserManager<TableUser> userManager)
        {
            this.userManager = userManager;
        }
        [Authorize]
        public IActionResult Index()
        {
            var users = userManager.Users;
            var viewModel = new IndexViewModel
            {
                Users = users,
                IdsToChange = new string[] { }
            };
            return View(viewModel);
        }


        public async Task<ActionResult> Block(string id)
        {
            var user = userManager.FindByIdAsync(id).Result;

            user.LockoutEnd = DateTime.Today.AddDays(1);
            await userManager.UpdateAsync(user);

            return View(new IndexViewModel
            {
                Users = userManager.Users
            });
        }

        [HttpPost]
        public async Task<ActionResult> Block(IndexViewModel model)
        {
            IdentityResult result;
            if (ModelState.IsValid)
            {
                foreach (string userId in model.IdsToChange ?? new string[] { })
                {
                    var user = userManager.FindByIdAsync(userId).Result;
                    result = await userManager.SetLockoutEndDateAsync(user, DateTime.Today.AddDays(1));

                    if (!result.Succeeded)
                    {
                        return View("Error", result.Errors);
                    }
                }
               

            }
            return View("Error", new string[] { "Роль не найдена" });
        }

        [HttpPost]
        public async Task<ActionResult> Delete(IndexViewModel model)
        {
            IdentityResult result;
            foreach (string userId in model.IdsToChange ?? new string[] { })
            {
                var user = userManager.FindByIdAsync(userId).Result;
                result = await userManager.DeleteAsync(user);

                if (!result.Succeeded)
                {
                    return View("Error", result.Errors);
                }
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
