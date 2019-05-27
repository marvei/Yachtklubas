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
    }
}
