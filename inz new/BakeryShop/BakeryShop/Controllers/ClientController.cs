using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BakeryShop.Models;

namespace BakeryShop.Controllers
{
    public class ClientController : Controller
    {
        private readonly BakeryContext _context = new BakeryContext();

        // GET: Client
        public ActionResult Index()
        {
            var Client = _context.Client.ToList();
            return View(Client);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Client Client)
        {
            if (ModelState.IsValid)
            {
                _context.Client.Add(Client);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Client);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Client = _context.Client.SingleOrDefault(e => e.ClientId == id);
            if (Client == null)
            {
                return HttpNotFound();
            }
            return View(Client);
        }

        [HttpPost]
        public ActionResult Edit(Client Client)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(Client).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Client);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Client = _context.Client.SingleOrDefault(e => e.ClientId == id);
            if (Client == null)
            {
                return HttpNotFound();
            }
            return View(Client);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Client = _context.Client.SingleOrDefault(e => e.ClientId == id);
            if (Client == null)
            {
                return HttpNotFound();
            }
            return View(Client);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var Client = _context.Client.SingleOrDefault(x => x.ClientId == id);
            _context.Client.Remove(Client ?? throw new InvalidOperationException());
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}