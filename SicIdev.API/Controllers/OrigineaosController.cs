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
    public class OrigineaosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Origineaos
        public ActionResult Index()
        {
            return View(db.Origineaos.ToList());
        }

        // GET: Origineaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Origineao origineao = db.Origineaos.Find(id);
            if (origineao == null)
            {
                return HttpNotFound();
            }
            return View(origineao);
        }

        // GET: Origineaos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Origineaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Origine")] Origineao origineao)
        {
            if (ModelState.IsValid)
            {
                db.Origineaos.Add(origineao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(origineao);
        }

        // GET: Origineaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Origineao origineao = db.Origineaos.Find(id);
            if (origineao == null)
            {
                return HttpNotFound();
            }
            return View(origineao);
        }

        // POST: Origineaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Origine")] Origineao origineao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(origineao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(origineao);
        }

        // GET: Origineaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Origineao origineao = db.Origineaos.Find(id);
            if (origineao == null)
            {
                return HttpNotFound();
            }
            return View(origineao);
        }

        // POST: Origineaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Origineao origineao = db.Origineaos.Find(id);
            db.Origineaos.Remove(origineao);
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
