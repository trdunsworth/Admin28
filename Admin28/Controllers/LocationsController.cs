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
    public class LocationsController : Controller
    {
        private HCEntities db = new HCEntities();

        // GET: Locations
        public ActionResult Index()
        {
            return View(db.JC_HC_LOI.OrderBy(JC_HC_LOI => JC_HC_LOI.ID).ToList());
        }

        // GET: Locations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_LOI jc_hc_loi = db.JC_HC_LOI.Find(id);
            if (jc_hc_loi == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_loi);
        }

        // GET: Locations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Locations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,HNDR_BLCK,LOI_GRP_ID,ZIP,EFEANME,ESTNUM,EDIRPRE,EFEATYP,COMMON_NAME,CITY,ACTIVE,ADDRESS,ESZ")] JC_HC_LOI jc_hc_loi)
        {
            if (ModelState.IsValid)
            {
                db.JC_HC_LOI.Add(jc_hc_loi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jc_hc_loi);
        }

        // GET: Locations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_LOI jc_hc_loi = db.JC_HC_LOI.Find(id);
            if (jc_hc_loi == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_loi);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,HNDR_BLCK,LOI_GRP_ID,ZIP,EFEANME,ESTNUM,EDIRPRE,EFEATYP,COMMON_NAME,CITY,ACTIVE,ADDRESS,ESZ")] JC_HC_LOI jc_hc_loi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jc_hc_loi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jc_hc_loi);
        }

        // GET: Locations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_LOI jc_hc_loi = db.JC_HC_LOI.Find(id);
            if (jc_hc_loi == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_loi);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JC_HC_LOI jc_hc_loi = db.JC_HC_LOI.Find(id);
            db.JC_HC_LOI.Remove(jc_hc_loi);
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
