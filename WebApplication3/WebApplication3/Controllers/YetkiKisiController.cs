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
    public class YetkiKisiController : Controller
    {
        private ErasmusContext db = new ErasmusContext();

        // GET: YetkiKisi
        public ActionResult Index()
        {
            return View(db.yetkiKisi.ToList());
        }

        // GET: YetkiKisi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YetkiKisi yetkiKisi = db.yetkiKisi.Find(id);
            if (yetkiKisi == null)
            {
                return HttpNotFound();
            }
            return View(yetkiKisi);
        }

        // GET: YetkiKisi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YetkiKisi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "YetkiKisiID,YetkiAd")] YetkiKisi yetkiKisi)
        {
            if (ModelState.IsValid)
            {
                db.yetkiKisi.Add(yetkiKisi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yetkiKisi);
        }

        // GET: YetkiKisi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YetkiKisi yetkiKisi = db.yetkiKisi.Find(id);
            if (yetkiKisi == null)
            {
                return HttpNotFound();
            }
            return View(yetkiKisi);
        }

        // POST: YetkiKisi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "YetkiKisiID,YetkiAd")] YetkiKisi yetkiKisi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yetkiKisi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yetkiKisi);
        }

        // GET: YetkiKisi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            YetkiKisi yetkiKisi = db.yetkiKisi.Find(id);
            if (yetkiKisi == null)
            {
                return HttpNotFound();
            }
            return View(yetkiKisi);
        }

        // POST: YetkiKisi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            YetkiKisi yetkiKisi = db.yetkiKisi.Find(id);
            db.yetkiKisi.Remove(yetkiKisi);
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
