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
    public class DomainesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Domaines
        public ActionResult Index()
        {
            var domaines = db.Domaines.Include(d => d.Departement);
            return View(domaines.ToList());
        }

        // GET: Domaines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Domaine domaine = db.Domaines.Find(id);
            if (domaine == null)
            {
                return HttpNotFound();
            }
            return View(domaine);
        }

        // GET: Domaines/Create
        public ActionResult Create()
        {
            ViewBag.DepartementId = new SelectList(db.Departements, "Id", "Designation");
            return View();
        }

        // POST: Domaines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Designation,DepartementId")] Domaine domaine)
        {
            if (ModelState.IsValid)
            {
                db.Domaines.Add(domaine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartementId = new SelectList(db.Departements, "Id", "Designation", domaine.DepartementId);
            return View(domaine);
        }

        // GET: Domaines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Domaine domaine = db.Domaines.Find(id);
            if (domaine == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartementId = new SelectList(db.Departements, "Id", "Designation", domaine.DepartementId);
            return View(domaine);
        }

        // POST: Domaines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Designation,DepartementId")] Domaine domaine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(domaine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartementId = new SelectList(db.Departements, "Id", "Designation", domaine.DepartementId);
            return View(domaine);
        }

        // GET: Domaines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Domaine domaine = db.Domaines.Find(id);
            if (domaine == null)
            {
                return HttpNotFound();
            }
            return View(domaine);
        }

        // POST: Domaines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Domaine domaine = db.Domaines.Find(id);
            db.Domaines.Remove(domaine);
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
