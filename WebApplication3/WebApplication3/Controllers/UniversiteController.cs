using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication3.DbC;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class UniversiteController : Controller
    {
        private ErasmusContext db = new ErasmusContext();

        // GET: Universite
        public ActionResult Index(String arama)
        {
            var universite = from s in db.Universite
                              select s;
            if (!String.IsNullOrEmpty(arama))
            {
                universite = universite.Where(s => s.Sehirler.ToUpper().Contains(arama.ToUpper()));
            }
            return View(universite.ToList());
        }

        // GET: Universite/Details/5
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Details(int? id)
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

        // GET: Universite/Create
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Universite/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include = "UniversiteID,Ad,Sehirler,Bolum")] Universite universite)
        {
            if (ModelState.IsValid)
            {
                db.Universite.Add(universite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(universite);
        }

        // GET: Universite/Edit/5
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Edit(int? id)
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
        public ActionResult Edit([Bind(Include = "UniversiteID,Ad,Sehirler,Bolum")] Universite universite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(universite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(universite);
        }

        // GET: Universite/Delete/5
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Delete(int? id)
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

        // POST: Universite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Universite universite = db.Universite.Find(id);
            db.Universite.Remove(universite);
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
