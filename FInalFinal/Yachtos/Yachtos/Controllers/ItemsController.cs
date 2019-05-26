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
           
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
    }
}
