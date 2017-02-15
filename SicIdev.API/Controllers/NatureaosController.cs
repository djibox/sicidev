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
    public class NatureaosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Natureaos
        public ActionResult Index()
        {
            return View(db.Natureaos.ToList());
        }

        // GET: Natureaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Natureao natureao = db.Natureaos.Find(id);
            if (natureao == null)
            {
                return HttpNotFound();
            }
            return View(natureao);
        }

        // GET: Natureaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Natureaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nature")] Natureao natureao)
        {
            if (ModelState.IsValid)
            {
                db.Natureaos.Add(natureao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(natureao);
        }

        // GET: Natureaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Natureao natureao = db.Natureaos.Find(id);
            if (natureao == null)
            {
                return HttpNotFound();
            }
            return View(natureao);
        }

        // POST: Natureaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nature")] Natureao natureao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(natureao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(natureao);
        }

        // GET: Natureaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Natureao natureao = db.Natureaos.Find(id);
            if (natureao == null)
            {
                return HttpNotFound();
            }
            return View(natureao);
        }

        // POST: Natureaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Natureao natureao = db.Natureaos.Find(id);
            db.Natureaos.Remove(natureao);
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
