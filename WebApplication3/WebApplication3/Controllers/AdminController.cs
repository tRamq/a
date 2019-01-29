using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.DbC;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class AdminController : Controller
    {
        private ErasmusContext db = new ErasmusContext();
        // GET: Admin
        [Authorize(Roles = "Admin")]
        public ActionResult UyelerIndex()
        {
            return View(db.Uyeler.ToList());
        }
        [Authorize(Roles = "Admin")]
        // GET: Uyeler/Details/5
        public ActionResult UyelerDetails(int? id)
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
        [Authorize(Roles = "Admin")]
        // GET: Uyeler/Create
        public ActionResult UyelerCreate()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        // POST: Uyeler/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UyelerCreate([Bind(Include = "UyeID,Ad,Soyad,GidilecekSehir,GidilecekUniversite,Bolum,IsImkani,Email,Sifre,SifreTekrarı")] Uyeler uyeler)
        {
            if (ModelState.IsValid)
            {
                db.Uyeler.Add(uyeler);
                db.SaveChanges();
                return RedirectToAction("UyelerIndex");
            }

            return View(uyeler);
        }
        [Authorize(Roles = "Admin")]
        // GET: Uyeler/Edit/5
        public ActionResult UyelerEdit(int? id)
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
        [Authorize(Roles = "Admin")]
        // POST: Uyeler/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UyelerEdit([Bind(Include = "UyeID,Ad,Soyad,GidilecekSehir,GidilecekUniversite,Bolum,IsImkani,Email,Sifre,SifreTekrarı")] Uyeler uyeler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uyeler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("UyelerIndex");
            }
            return View(uyeler);
        }
        [Authorize(Roles = "Admin")]
        // GET: Uyeler/Delete/5
        public ActionResult UyelerDelete(int? id)
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
        [Authorize(Roles = "Admin")]
        // POST: Uyeler/Delete/5
        [HttpPost, ActionName("UyelerDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult UyelerDeleteConfirmed(int id)
        {
            Uyeler uyeler = db.Uyeler.Find(id);
            db.Uyeler.Remove(uyeler);
            db.SaveChanges();
            return RedirectToAction("UyelerIndex");
        }

        [Authorize(Roles ="Admin")]
        public ActionResult IsimkanlariIndex()
        {
            
            return View(db.IsImkanlari.ToList());
        }
        [Authorize(Roles = "Admin")]
        public ActionResult IsimkanlariCreate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult IsimkanlariCreate([Bind(Include = "IsImkanlariID,Sehir,SirketIsmi,Bolum")] IsImkanlari isImkanlari)
        {
            if (ModelState.IsValid)
            {
                db.IsImkanlari.Add(isImkanlari);
                db.SaveChanges();
                return RedirectToAction("IsimkanlariIndex");
            }

            return View(isImkanlari);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult IsimkanlariDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IsImkanlari isImkanlari = db.IsImkanlari.Find(id);
            if (isImkanlari == null)
            {
                return HttpNotFound();
            }
            return View(isImkanlari);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult IsimkanlariEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IsImkanlari isImkanlari = db.IsImkanlari.Find(id);
            if (isImkanlari == null)
            {
                return HttpNotFound();
            }
            return View(isImkanlari);
        }

        // POST: IsImkanlari/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult IsimkanlariEdit([Bind(Include = "IsImkanlariID,Sehir,SirketIsmi,Bolum")] IsImkanlari isImkanlari)
        {
            if (ModelState.IsValid)
            {
                db.Entry(isImkanlari).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("IsimkanlariIndex");
            }
            return View(isImkanlari);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult IsimkanlariDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IsImkanlari isImkanlari = db.IsImkanlari.Find(id);
            if (isImkanlari == null)
            {
                return HttpNotFound();
            }
            return View(isImkanlari);
        }

        // POST: IsImkanlari/Delete/5
        [HttpPost, ActionName("IsimkanlariDelete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult IsimkanlariDeleteConfirmed(int id)
        {
            IsImkanlari isImkanlari = db.IsImkanlari.Find(id);
            db.IsImkanlari.Remove(isImkanlari);
            db.SaveChanges();
            return RedirectToAction("IsimkanlariIndex");
        }
        [Authorize(Roles = "Admin")]
        public ActionResult KonaklamaIndex()
        {
            return View(db.Konaklama.ToList());
        }
        [Authorize(Roles = "Admin")]
        // GET: Konaklama/Details/5
        public ActionResult KonaklamaDetails(int? id)
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
        [Authorize(Roles = "Admin")]
        // GET: Konaklama/Create
        public ActionResult KonaklamaCreate()
        {
            return View();
        }

        // POST: Konaklama/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult KonaklamaCreate([Bind(Include = "KonaklamaID,Ad,Sehirler,Fiyat,YurtmuEvmi,YakinlikUzaklik,KızmıErkek,KisiSayısı,Kaçoda")] Konaklama konaklama)
        {
            if (ModelState.IsValid)
            {
                db.Konaklama.Add(konaklama);
                db.SaveChanges();
                return RedirectToAction("KonaklamaIndex");
            }

            return View(konaklama);
        }

        // GET: Konaklama/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult KonaklamaEdit(int? id)
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
        [Authorize(Roles = "Admin")]
        public ActionResult KonaklamaEdit([Bind(Include = "KonaklamaID,Ad,Sehirler,Fiyat,YurtmuEvmi,YakinlikUzaklik,KızmıErkek,KisiSayısı,Kaçoda")] Konaklama konaklama)
        {
            if (ModelState.IsValid)
            {
                db.Entry(konaklama).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("KonaklamaIndex");
            }
            return View(konaklama);
        }

        // GET: Konaklama/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult KonaklamaDelete(int? id)
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
        [Authorize(Roles = "Admin")]
        // POST: Konaklama/Delete/5
        [HttpPost, ActionName("KonaklamaDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult KonaklamaDeleteConfirmed(int id)
        {
            Konaklama konaklama = db.Konaklama.Find(id);
            db.Konaklama.Remove(konaklama);
            db.SaveChanges();
            return RedirectToAction("KonaklamaIndex");
        }
        [Authorize(Roles = "Admin")]
        public ActionResult UniversiteIndex()
        {
            return View(db.Universite.ToList());
        }
        [Authorize(Roles = "Admin")]
        // GET: Universite/Details/5
        public ActionResult UniversiteDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Universite universite = db.Universite.Find(id);
            if (universite == null)
            {
                return HttpNotFound();
            }
            return View(universite);
        }
        [Authorize(Roles = "Admin")]
        // GET: Universite/Create
        public ActionResult UniversiteCreate()
        {
            return View();
        }

        // POST: Universite/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult UniversiteCreate([Bind(Include = "UniversiteID,Ad,Sehirler,Bolum")] Universite universite)
        {
            if (ModelState.IsValid)
            {
                db.Universite.Add(universite);
                db.SaveChanges();
                return RedirectToAction("UniversiteIndex");
            }

            return View(universite);
        }
        [Authorize(Roles = "Admin")]
        // GET: Universite/Edit/5
        public ActionResult UniversiteEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Universite universite = db.Universite.Find(id);
            if (universite == null)
            {
                return HttpNotFound();
            }
            return View(universite);
        }

        // POST: Universite/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult UniversiteEdit([Bind(Include = "UniversiteID,Ad,Sehirler,Bolum")] Universite universite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(universite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("UniversiteIndex");
            }
            return View(universite);
        }
        [Authorize(Roles = "Admin")]
        // GET: Universite/Delete/5
        public ActionResult UniversiteDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Universite universite = db.Universite.Find(id);
            if (universite == null)
            {
                return HttpNotFound();
            }
            return View(universite);
        }
        [Authorize(Roles = "Admin")]
        // POST: Universite/Delete/5
        [HttpPost, ActionName("UniversiteDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult UniversiteDeleteConfirmed(int id)
        {
            Universite universite = db.Universite.Find(id);
            db.Universite.Remove(universite);
            db.SaveChanges();
            return RedirectToAction("UniversiteIndex");
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