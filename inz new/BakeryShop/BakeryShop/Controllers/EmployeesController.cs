using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryShop.Models;

namespace BakeryShop.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly BakeryContext _context = new BakeryContext();

        // GET: Employees
        public ActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
            }
            return View(employee);
        }
    }
}