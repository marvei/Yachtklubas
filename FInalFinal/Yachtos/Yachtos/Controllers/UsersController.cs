using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Yachtos.Database;
using Yachtos.Models;

namespace Yachtos.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            User user = new User();
            return View(user.GetUsers());
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateConfirmed([Bind("Username, Password, Id,Teises,Email")] User user)
        {

            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            user.Create();

            return RedirectToAction(nameof(Index));
        }
    }
}
