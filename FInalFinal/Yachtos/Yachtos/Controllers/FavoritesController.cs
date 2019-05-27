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
    public class FavoritesController : Controller
    {
        public IActionResult Index()
        {
            Favorites favs = new Favorites();
            return View(favs.getFavs());
        }
        public IActionResult Create()
        {
            Favorites favs = new Favorites();
            return View(favs);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateConfirmed([Bind("UserId, ItemsId")] Favorites favorites)
        {
            //int c = int.Parse(Request.Form["UserId"]);


            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            favorites.Create();

            return RedirectToAction(nameof(Index));
        }
    }
}
