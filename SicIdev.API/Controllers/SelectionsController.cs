using SicIdev.API.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SicIdev.API.Controllers
{
    public class SelectionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Selections
        public ActionResult Index()
        {
            var selections = db.Selections.Include(s => s.Agent).Include(s => s.Client).Include(s => s.Departement).Include(s => s.Domaine).Include(s => s.Natureao).Include(s => s.Origineao).Include(s => s.Pays).Include(s => s.PriseEnCharge).Include(s => s.Typeao);
            return View(selections.ToList());
        }

        // GET: Selections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Selection selection = db.Selections.Find(id);
            if (selection == null)
            {
                return HttpNotFound();
            }
            List<Selection> list = new List<Selection>();
            list.Add(selection);
            return View(list);
        }

        // GET: Selections/Create
        public ActionResult Create()
        {
            ViewBag.AgentId = new SelectList(db.Agents, "Id", "UserId");
            ViewBag.ClientId = new SelectList(db.Clients, "Id", "Libelle");
            ViewBag.DepartementId = new SelectList(db.Departements, "Id", "Designation");
            ViewBag.DomaineId = new SelectList(db.Domaines, "Id", "Designation");
            ViewBag.NatureaoId = new SelectList(db.Natureaos, "Id", "Nature");
            ViewBag.OrigineaoId = new SelectList(db.Origineaos, "Id", "Origine");
            ViewBag.PaysId = new SelectList(db.Payses, "Id", "Designation");
            ViewBag.PriseEnChargeId = new SelectList(db.PriseEnCharges, "Id", "Libelle");
            ViewBag.TypeaoId = new SelectList(db.Typeaos, "Id", "Type");
            return View();
        }

        // POST: Selections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Projet,ProvenantDe,DepartementId,NatureaoId,Echeance,OrigineaoId,TypeaoId,DateConnaissance,PaysId,Ville,DomaineActivite,ClientId,Connu,Description,PriseEnChargeId,DomaineId,Commentaires,CadreDeConcertation,ComplementInfos,Partenaire,Observations,AgentId,VisaChefService,DateVisaCs,VisaServiceCom,DateVisaCom,VisaDg,DateVisaDg")] Selection selection)
        {
            if (ModelState.IsValid)
            {
                db.Selections.Add(selection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AgentId = new SelectList(db.Agents, "Id", "UserId", selection.AgentId);
            ViewBag.ClientId = new SelectList(db.Clients, "Id", "Libelle", selection.ClientId);
            ViewBag.DepartementId = new SelectList(db.Departements, "Id", "Designation", selection.DepartementId);
            ViewBag.DomaineId = new SelectList(db.Domaines, "Id", "Designation", selection.DomaineId);
            ViewBag.NatureaoId = new SelectList(db.Natureaos, "Id", "Nature", selection.NatureaoId);
            ViewBag.OrigineaoId = new SelectList(db.Origineaos, "Id", "Origine", selection.OrigineaoId);
            ViewBag.PaysId = new SelectList(db.Payses, "Id", "Designation", selection.PaysId);
            ViewBag.PriseEnChargeId = new SelectList(db.PriseEnCharges, "Id", "Libelle", selection.PriseEnChargeId);
            ViewBag.TypeaoId = new SelectList(db.Typeaos, "Id", "Type", selection.TypeaoId);
            return View(selection);
        }

        // GET: Selections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Selection selection = db.Selections.Find(id);
            if (selection == null)
            {
                return HttpNotFound();
            }
            ViewBag.AgentId = new SelectList(db.Agents, "Id", "UserId", selection.AgentId);
            ViewBag.ClientId = new SelectList(db.Clients, "Id", "Libelle", selection.ClientId);
            ViewBag.DepartementId = new SelectList(db.Departements, "Id", "Designation", selection.DepartementId);
            ViewBag.DomaineId = new SelectList(db.Domaines, "Id", "Designation", selection.DomaineId);
            ViewBag.NatureaoId = new SelectList(db.Natureaos, "Id", "Nature", selection.NatureaoId);
            ViewBag.OrigineaoId = new SelectList(db.Origineaos, "Id", "Origine", selection.OrigineaoId);
            ViewBag.PaysId = new SelectList(db.Payses, "Id", "Designation", selection.PaysId);
            ViewBag.PriseEnChargeId = new SelectList(db.PriseEnCharges, "Id", "Libelle", selection.PriseEnChargeId);
            ViewBag.TypeaoId = new SelectList(db.Typeaos, "Id", "Type", selection.TypeaoId);
            return View(selection);
        }

        // POST: Selections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Projet,ProvenantDe,DepartementId,NatureaoId,Echeance,OrigineaoId,TypeaoId,DateConnaissance,PaysId,Ville,DomaineActivite,ClientId,Connu,Description,PriseEnChargeId,DomaineId,Commentaires,CadreDeConcertation,ComplementInfos,Partenaire,Observations,AgentId,VisaChefService,DateVisaCs,VisaServiceCom,DateVisaCom,VisaDg,DateVisaDg")] Selection selection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(selection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AgentId = new SelectList(db.Agents, "Id", "UserId", selection.AgentId);
            ViewBag.ClientId = new SelectList(db.Clients, "Id", "Libelle", selection.ClientId);
            ViewBag.DepartementId = new SelectList(db.Departements, "Id", "Designation", selection.DepartementId);
            ViewBag.DomaineId = new SelectList(db.Domaines, "Id", "Designation", selection.DomaineId);
            ViewBag.NatureaoId = new SelectList(db.Natureaos, "Id", "Nature", selection.NatureaoId);
            ViewBag.OrigineaoId = new SelectList(db.Origineaos, "Id", "Origine", selection.OrigineaoId);
            ViewBag.PaysId = new SelectList(db.Payses, "Id", "Designation", selection.PaysId);
            ViewBag.PriseEnChargeId = new SelectList(db.PriseEnCharges, "Id", "Libelle", selection.PriseEnChargeId);
            ViewBag.TypeaoId = new SelectList(db.Typeaos, "Id", "Type", selection.TypeaoId);
            return View(selection);
        }

        // GET: Selections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Selection selection = db.Selections.Find(id);
            if (selection == null)
            {
                return HttpNotFound();
            }
            return View(selection);
        }

        // POST: Selections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Selection selection = db.Selections.Find(id);
            db.Selections.Remove(selection);
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
