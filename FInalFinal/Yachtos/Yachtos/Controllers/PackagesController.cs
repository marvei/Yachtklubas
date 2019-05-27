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
    public class PackagesController : Controller
    {
        public IActionResult Index()
        {
            Packages pack = new Packages();
            return View(pack.GetPackages());
        }
        public IActionResult Create()
        {
            Packages pack = new Packages();
            return View(pack);
        }
    }
}
