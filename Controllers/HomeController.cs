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

namespace _123.Controllers
{
    public class HomeController : Controller
    {
        public UserManager<IdentityUser> userManager;

        public HomeController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        [Authorize]
        public IActionResult Index()
        {
            var users = userManager.Users;
            var viewModel = new IndexViewModel
            {
                Users = users
            };
            return View(viewModel);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
