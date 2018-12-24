using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BakeryShop.Models;

namespace BakeryShop.Controllers
{
    public class ProduktyController : Controller
    {
        private readonly BakeryContext _context = new BakeryContext();

        // GET: Produkty
        public ActionResult Index()
        {
            var Produkty = _context.Produkty.ToList();
            return View(Produkty);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produkt Produkt)
        {
            if (ModelState.IsValid)
            {
                _context.Produkty.Add(Produkt);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Produkt);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Produkt = _context.Produkty.SingleOrDefault(e => e.ProduktId == id);
            if (Produkt == null)
            {
                return HttpNotFound();
            }
            return View(Produkt);
        }

        [HttpPost]
        public ActionResult Edit(Produkt Produkt)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(Produkt).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Produkt);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Produkt = _context.Produkty.SingleOrDefault(e => e.ProduktId == id);
            if (Produkt == null)
            {
                return HttpNotFound();
            }
            return View(Produkt);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Produkt = _context.Produkty.SingleOrDefault(e => e.ProduktId == id);
            if (Produkt == null)
            {
                return HttpNotFound();
            }
            return View(Produkt);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var Produkt = _context.Produkty.SingleOrDefault(x => x.ProduktId == id);
            _context.Produkty.Remove(Produkt ?? throw new InvalidOperationException());
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}