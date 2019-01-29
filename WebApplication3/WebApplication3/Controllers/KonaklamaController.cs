using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.DbC;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class KonaklamaController : Controller
    {
        private ErasmusContext db = new ErasmusContext();

        // GET: Konaklama
        public ActionResult Index(String arama)
        {
            var konaklama = from s in db.Konaklama
                              select s;
            if (!String.IsNullOrEmpty(arama))
            {
                konaklama = konaklama.Where(s => s.Ad.ToUpper().Contains(arama.ToUpper()));
            }
            return View(konaklama.ToList());
        }

        // GET: Konaklama/Details/5
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Konaklama konaklama = db.Konaklama.Find(id);
            if (konaklama == null)
            {
                return HttpNotFound();
            }
            return View(konaklama);
        }

        // GET: Konaklama/Create
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Konaklama/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KonaklamaID,Ad,Sehirler,Fiyat,YurtmuEvmi,YakinlikUzaklik,KızmıErkek,KisiSayısı,Kaçoda")] Konaklama konaklama)
        {
            if (ModelState.IsValid)
            {
                db.Konaklama.Add(konaklama);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(konaklama);
        }

        // GET: Konaklama/Edit/5
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Konaklama konaklama = db.Konaklama.Find(id);
            if (konaklama == null)
            {
                return HttpNotFound();
            }
            return View(konaklama);
        }

        // POST: Konaklama/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KonaklamaID,Ad,Sehirler,Fiyat,YurtmuEvmi,YakinlikUzaklik,KızmıErkek,KisiSayısı,Kaçoda")] Konaklama konaklama)
        {
            if (ModelState.IsValid)
            {
                db.Entry(konaklama).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(konaklama);
        }

        // GET: Konaklama/Delete/5
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Konaklama konaklama = db.Konaklama.Find(id);
            if (konaklama == null)
            {
                return HttpNotFound();
            }
            return View(konaklama);
        }

        // POST: Konaklama/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Konaklama konaklama = db.Konaklama.Find(id);
            db.Konaklama.Remove(konaklama);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
