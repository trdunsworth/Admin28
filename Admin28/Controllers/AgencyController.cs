using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Admin28.Models;

namespace Admin28.Controllers
{
    public class AgencyController : Controller
    {
        private HCEntities db = new HCEntities();

        // GET: Agency
        public ActionResult Index()
        {
            return View(db.JC_HC_AGENCY.OrderBy(JC_HC_AGENCY => JC_HC_AGENCY.ID).ToList());
        }

        // GET: Agency/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_AGENCY jc_hc_agency = db.JC_HC_AGENCY.Find(id);
            if (jc_hc_agency == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_agency);
        }

        // GET: Agency/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agency/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,AG_ID,UNITS")] JC_HC_AGENCY jc_hc_agency)
        {
            if (ModelState.IsValid)
            {
                db.JC_HC_AGENCY.Add(jc_hc_agency);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jc_hc_agency);
        }

        // GET: Agency/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_AGENCY jc_hc_agency = db.JC_HC_AGENCY.Find(id);
            if (jc_hc_agency == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_agency);
        }

        // POST: Agency/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,AG_ID,UNITS")] JC_HC_AGENCY jc_hc_agency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jc_hc_agency).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jc_hc_agency);
        }

        // GET: Agency/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_AGENCY jc_hc_agency = db.JC_HC_AGENCY.Find(id);
            if (jc_hc_agency == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_agency);
        }

        // POST: Agency/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            JC_HC_AGENCY jc_hc_agency = db.JC_HC_AGENCY.Find(id);
            db.JC_HC_AGENCY.Remove(jc_hc_agency);
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
