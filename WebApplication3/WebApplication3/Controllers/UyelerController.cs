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
    public class UyelerController : Controller
    {
        private ErasmusContext db = new ErasmusContext();

        // GET: Uyeler
        public ActionResult Index()
        {
            return View(db.Uyeler.ToList());
        }
       
        // GET: Uyeler/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uyeler uyeler = db.Uyeler.Find(id);
            if (uyeler == null)
            {
                return HttpNotFound();
            }
            return View(uyeler);
        }

        // GET: Uyeler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Uyeler/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UyeID,Ad,Soyad,GidilecekSehir,GidilecekUniversite,Bolum,IsImkani,Email,Sifre,SifreTekrarı")] Uyeler uyeler)
        {
            if (ModelState.IsValid)
            {
                db.Uyeler.Add(uyeler);
                db.SaveChanges();
                
            }

            return View(uyeler);
        }

        // GET: Uyeler/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uyeler uyeler = db.Uyeler.Find(id);
            if (uyeler == null)
            {
                return HttpNotFound();
            }
            return View(uyeler);
        }

        // POST: Uyeler/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UyeID,Ad,Soyad,GidilecekSehir,GidilecekUniversite,Bolum,IsImkani,Email,Sifre,SifreTekrarı")] Uyeler uyeler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uyeler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uyeler);
        }

        // GET: Uyeler/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uyeler uyeler = db.Uyeler.Find(id);
            if (uyeler == null)
            {
                return HttpNotFound();
            }
            return View(uyeler);
        }

        // POST: Uyeler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uyeler uyeler = db.Uyeler.Find(id);
            db.Uyeler.Remove(uyeler);
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
