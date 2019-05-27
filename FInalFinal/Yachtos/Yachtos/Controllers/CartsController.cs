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
        public IActionResult CreateConfirmed([Bind("CartId, ItemsId")] Cart cart)
        {
            //int c = int.Parse(Request.Form["UserId"]);


            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            cart.Create();

            return RedirectToAction(nameof(Index));
        }
    }
}
