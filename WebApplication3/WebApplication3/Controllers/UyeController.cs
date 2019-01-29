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
    public class UyeController : Controller
    {
        private ErasmusContext db = new ErasmusContext();

        // GET: Uye
        public ActionResult Index()
        {
            
            return View(db.Uye.ToList());
        }
        public ActionResult UyeOlustur()
        {

            return View();
        }
        [HttpPost]
        public ActionResult UyeOlustur(Uye uye)
        {
            if (ModelState.IsValid)
            {
                var kullanicikontrol = db.Uye.Where(x => x.Ad == uye.Ad || x.Email == uye.Email).FirstOrDefault();
            }

            return View(uye);
        }
        // GET: Uye/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uye uye = db.Uye.Find(id);
            if (uye == null)
            {
                return HttpNotFound();
            }
            return View(uye);
        }

        // GET: Uye/Create
        public ActionResult Create()
        {
            //ViewBag.IsImkanlariID = new SelectList(db.IsImkanlari, "IsImkanlariID", "Sehir");
            //ViewBag.KonaklamaID = new SelectList(db.Konaklama, "KonaklamaID", "Ad");
            //ViewBag.UniversiteID = new SelectList(db.Universite, "UniversiteID", "Ad");
            //ViewBag.YetkiKisiID = new SelectList(db.yetkiKisi, "YetkiKisiID", "YetkiAd");
            return View();
        }

        // POST: Uye/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UyeID,Ad,Soyad,GidilecekSehir,GidilecekUniversite,Bolum,IsImkani,Email,Sifre,SifreTekrarı")] Uye uye)
        {
            if (ModelState.IsValid)
            {
                db.Uye.Add(uye);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.IsImkanlariID = new SelectList(db.IsImkanlari, "IsImkanlariID", "Sehir", uye.IsImkanlariID);
            //ViewBag.KonaklamaID = new SelectList(db.Konaklama, "KonaklamaID", "Ad", uye.KonaklamaID);
            //ViewBag.UniversiteID = new SelectList(db.Universite, "UniversiteID", "Ad", uye.UniversiteID);
            //ViewBag.YetkiKisiID = new SelectList(db.yetkiKisi, "YetkiKisiID", "YetkiAd", uye.YetkiKisiID);
            return View(uye);
        }

        // GET: Uye/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uye uye = db.Uye.Find(id);
            if (uye == null)
            {
                return HttpNotFound();
            }
            ViewBag.IsImkanlariID = new SelectList(db.IsImkanlari, "IsImkanlariID", "Sehir", uye.IsImkanlariID);
            ViewBag.KonaklamaID = new SelectList(db.Konaklama, "KonaklamaID", "Ad", uye.KonaklamaID);
            ViewBag.UniversiteID = new SelectList(db.Universite, "UniversiteID", "Ad", uye.UniversiteID);
            ViewBag.YetkiKisiID = new SelectList(db.yetkiKisi, "YetkiKisiID", "YetkiAd", uye.YetkiKisiID);
            return View(uye);
        }

        // POST: Uye/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UyeID,UniversiteID,KonaklamaID,IsImkanlariID,YetkiKisiID,Ad,Soyad,GidilecekSehir,GidilecekUniversite,Bolum,IsImkani,Email,Sifre,SifreTekrarı")] Uye uye)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uye).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IsImkanlariID = new SelectList(db.IsImkanlari, "IsImkanlariID", "Sehir", uye.IsImkanlariID);
            ViewBag.KonaklamaID = new SelectList(db.Konaklama, "KonaklamaID", "Ad", uye.KonaklamaID);
            ViewBag.UniversiteID = new SelectList(db.Universite, "UniversiteID", "Ad", uye.UniversiteID);
            ViewBag.YetkiKisiID = new SelectList(db.yetkiKisi, "YetkiKisiID", "YetkiAd", uye.YetkiKisiID);
            return View(uye);
        }

        // GET: Uye/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uye uye = db.Uye.Find(id);
            if (uye == null)
            {
                return HttpNotFound();
            }
            return View(uye);
        }

        // POST: Uye/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uye uye = db.Uye.Find(id);
            db.Uye.Remove(uye);
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
