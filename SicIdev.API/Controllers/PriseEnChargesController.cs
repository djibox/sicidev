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
    public class PriseEnChargesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PriseEnCharges
        public ActionResult Index()
        {
            return View(db.PriseEnCharges.ToList());
        }

        // GET: PriseEnCharges/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriseEnCharge priseEnCharge = db.PriseEnCharges.Find(id);
            if (priseEnCharge == null)
            {
                return HttpNotFound();
            }
            return View(priseEnCharge);
        }

        // GET: PriseEnCharges/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PriseEnCharges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Libelle")] PriseEnCharge priseEnCharge)
        {
            if (ModelState.IsValid)
            {
                db.PriseEnCharges.Add(priseEnCharge);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(priseEnCharge);
        }

        // GET: PriseEnCharges/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriseEnCharge priseEnCharge = db.PriseEnCharges.Find(id);
            if (priseEnCharge == null)
            {
                return HttpNotFound();
            }
            return View(priseEnCharge);
        }

        // POST: PriseEnCharges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Libelle")] PriseEnCharge priseEnCharge)
        {
            if (ModelState.IsValid)
            {
                db.Entry(priseEnCharge).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(priseEnCharge);
        }

        // GET: PriseEnCharges/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PriseEnCharge priseEnCharge = db.PriseEnCharges.Find(id);
            if (priseEnCharge == null)
            {
                return HttpNotFound();
            }
            return View(priseEnCharge);
        }

        // POST: PriseEnCharges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PriseEnCharge priseEnCharge = db.PriseEnCharges.Find(id);
            db.PriseEnCharges.Remove(priseEnCharge);
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
