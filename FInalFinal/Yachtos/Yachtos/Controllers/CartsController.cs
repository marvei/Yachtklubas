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
    public class CartsController : Controller
    {
        public IActionResult Index()
        {
            Cart cart = new Cart();
            return View(cart.getCarts());
        }
        public IActionResult Create()
        {
            Cart cart = new Cart();
            return View(cart);
        }
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateConfirmed([Bind("ItemsId")] Cart cart)
        {
            //int c = int.Parse(Request.Form["UserId"]);
            
            //Cart cart = new Cart();
            //cart.ItemsId = ItemsId;
            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            cart.Create();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult EditConfirmed([Bind("ItemsId")] Cart cart)
        {

            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            cart.Update();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            int? storid = id;
            Items stor = new Items();
            return View(stor.GetItem(id: storid));
        }
    }
}
