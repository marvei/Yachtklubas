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
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee();
            return View(employee.GetEmployee());
        }
        public IActionResult Create()
        {
            Employee employee = new Employee();
            return View(employee);
        }
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateConfirmed([Bind("EmployeeId, fk_User")] Employee employee)
        {

            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            employee.Create();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(string id)
        {
            string EmployeeId = id;
            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            Employee emp = new Employee();
            return View(emp.GetEmployee(id: EmployeeId));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            string EmployeeId = id;
            DatabaseContext context = HttpContext.RequestServices.GetService(typeof(DatabaseContext)) as DatabaseContext;
            Employee emp = new Employee();
            emp.DeleteEmployeeById(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
