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
    public class TypeaosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Typeaos
        public ActionResult Index()
        {
            return View(db.Typeaos.ToList());
        }

        // GET: Typeaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Typeao typeao = db.Typeaos.Find(id);
            if (typeao == null)
            {
                return HttpNotFound();
            }
            return View(typeao);
        }

        // GET: Typeaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Typeaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type")] Typeao typeao)
        {
            if (ModelState.IsValid)
            {
                db.Typeaos.Add(typeao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeao);
        }

        // GET: Typeaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Typeao typeao = db.Typeaos.Find(id);
            if (typeao == null)
            {
                return HttpNotFound();
            }
            return View(typeao);
        }

        // POST: Typeaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type")] Typeao typeao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeao);
        }

        // GET: Typeaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Typeao typeao = db.Typeaos.Find(id);
            if (typeao == null)
            {
                return HttpNotFound();
            }
            return View(typeao);
        }

        // POST: Typeaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Typeao typeao = db.Typeaos.Find(id);
            db.Typeaos.Remove(typeao);
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
