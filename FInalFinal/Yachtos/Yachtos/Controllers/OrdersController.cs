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
    public class OrdersController : Controller
    {
            public IActionResult Index()
            {
                Order order = new Order();
                return View(order.GetOrder());
            }
            public IActionResult Create()
            {
                Order order = new Order();
                return View(order);
            }
            [HttpPost, ActionName("Create")]
            [ValidateAntiForgeryToken]
            public IActionResult CreateConfirmed([Bind("EmployeeId, UserId")] Order order)
            {
                int c = int.Parse(Request.Form["UserId"]);


                DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
                order.Create();

                return RedirectToAction(nameof(Index));
            }

        public IActionResult Edit(int? id)
        {
            int? PollId = id;
            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            Order poll = new Order();
            return View(poll.GetOrder(id: PollId));
        }
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public IActionResult EditConfirmed([Bind("id, descprition")] Order poll)
        {

            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            poll.Update();

            return RedirectToAction(nameof(Index));
        }

    }
}
