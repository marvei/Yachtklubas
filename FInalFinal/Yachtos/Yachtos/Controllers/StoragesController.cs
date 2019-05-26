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
    public class StoragesController : Controller
    {
        public IActionResult Index()
        {
            Storage storage= new Storage();
            return View(storage.GetStorage());
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateConfirmed([Bind("Id, Item, description, Image, kiekis")] Storage storage)
        {

            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            storage.Create();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            int? PollId = id;
            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            Storage poll = new Storage();
            return View(poll.GetPoll(id: PollId));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            int PollId = id;
            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            Storage poll = new Storage();
            poll.DeletePollById(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            int? PollId = id;
            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            Storage poll = new Storage();
            return View(poll.GetPoll(id: PollId));
        }

        public IActionResult Details(int? id)
        {
            int? storid = id;
            Storage stor = new Storage();
            return View(stor.GetPoll(id: storid));
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult EditConfirmed([Bind("id, Item,description,Image,kiekis")] Storage poll)
        {

            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            poll.Update();

            return RedirectToAction(nameof(Index));
        }
    }
}
