using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SicIdev.API.Models;

namespace SicIdev.API.Controllers
{
    public class PaysController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Pays
        public ActionResult Index()
        {
            return View(db.Payses.ToList());
        }

        // GET: Pays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pays pays = db.Payses.Find(id);
            if (pays == null)
            {
                return HttpNotFound();
            }
            return View(pays);
        }

        // GET: Pays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Designation")] Pays pays)
        {
            if (ModelState.IsValid)
            {
                db.Payses.Add(pays);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pays);
        }

        // GET: Pays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pays pays = db.Payses.Find(id);
            if (pays == null)
            {
                return HttpNotFound();
            }
            return View(pays);
        }

        // POST: Pays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Designation")] Pays pays)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pays).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pays);
        }

        // GET: Pays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pays pays = db.Payses.Find(id);
            if (pays == null)
            {
                return HttpNotFound();
            }
            return View(pays);
        }

        // POST: Pays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pays pays = db.Payses.Find(id);
            db.Payses.Remove(pays);
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
