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
    public class PackagesItemsController : Controller
    {
        public IActionResult Index()
        {
            PackagesItems packItems = new PackagesItems();
            return View(packItems.GetPackItems());
        }
        public IActionResult Create()
        {
            PackagesItems package = new PackagesItems();
            return View(package);
        }
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateConfirmed([Bind("id, PackageId, ItemsId")] PackagesItems packItems)
        {
            List<int> c = Request.Form["ItemsId"].Select(int.Parse).ToList();
                
                DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
                packItems.Create();

            return RedirectToAction(nameof(Index));
        }

    }
}
