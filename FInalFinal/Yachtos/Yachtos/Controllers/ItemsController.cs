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
    public class ItemsController : Controller
    {

        // GET: Items
        public IActionResult Index()
        {
            Items items = new Items();
            return View(items.GetItem());
        }
        public IActionResult Create()
        {
            Items items = new Items();
            return View(items);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateConfirmed([Bind("id, price, StorageId")] Items items)
        {
            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            items.Create();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            int? PollId = id;
            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            Items poll = new Items();
            return View(poll.GetItem(id: PollId));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            int PollId = id;
            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            Items poll = new Items();
            poll.DeleteItemById(id);
            return RedirectToAction(nameof(Index));
        }
    }
}