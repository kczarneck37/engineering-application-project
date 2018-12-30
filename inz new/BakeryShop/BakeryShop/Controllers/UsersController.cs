using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BakeryShop.Models;

namespace BakeryShop.Controllers
{
    public class UsersController : Controller
    {
        private readonly BakeryContext _context = new BakeryContext();

        // GET: Employees
        public ActionResult Index()
        {
            var Users = _context.Users.ToList();
            return View(Users);
        }
    }
}