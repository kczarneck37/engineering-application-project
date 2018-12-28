using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryShop.Models;

namespace BakeryShop.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            User userModel = new User();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(User userModel)
        {
            using (BakeryContext BakeryContext = new BakeryContext())
            {
                if (BakeryContext.Users.Any(x => x.UserName == userModel.UserName))
                {
                    ViewBag.DuplicateMessage = "Username already exist.";
                    return View("AddOrEdit", userModel);
                }

                BakeryContext.Users.Add(userModel);
                BakeryContext.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful.";
            return View("AddOrEdit", new User());
        }
    }
}