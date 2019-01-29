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
    public class IsImkanlariController : Controller
    {
        private ErasmusContext db = new ErasmusContext();

        // GET: IsImkanlari
        
        public ActionResult Index(String arama)
        {
            var isimkanlari = from s in db.IsImkanlari
                              select s;
            if(!String.IsNullOrEmpty(arama))
            {
                isimkanlari = isimkanlari.Where(s => s.SirketIsmi.ToUpper().Contains(arama.ToUpper()));
            }
            return View(isimkanlari.ToList());
        }

        // GET: IsImkanlari/Details/5
        [Authorize(Roles ="Admin,Uye")]
        public ActionResult Details(int? id)
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

        // GET: IsImkanlari/Create
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: IsImkanlari/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IsImkanlariID,Sehir,SirketIsmi,Bolum")] IsImkanlari isImkanlari)
        {
            if (ModelState.IsValid)
            {
                db.IsImkanlari.Add(isImkanlari);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(isImkanlari);
        }

        // GET: IsImkanlari/Edit/5
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Edit(int? id)
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
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Edit([Bind(Include = "IsImkanlariID,Sehir,SirketIsmi,Bolum")] IsImkanlari isImkanlari)
        {
            if (ModelState.IsValid)
            {
                db.Entry(isImkanlari).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(isImkanlari);
        }

        // GET: IsImkanlari/Delete/5
        [Authorize(Roles = "Admin,Uye")]
        public ActionResult Delete(int? id)
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
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IsImkanlari isImkanlari = db.IsImkanlari.Find(id);
            db.IsImkanlari.Remove(isImkanlari);
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
