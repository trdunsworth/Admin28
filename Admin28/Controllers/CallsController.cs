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
    public class CallsController : Controller
    {
        private HCEntities db = new HCEntities();

        // GET: Calls
        public ActionResult Index()
        {
            return View(db.JC_HC_CURENT.OrderBy(JC_HC_CURENT => JC_HC_CURENT.EID).ToList());
        }

        // GET: Calls/Details/5
        public ActionResult Details(int? eid)
        {
            if (eid == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_CURENT jc_hc_curent = db.JC_HC_CURENT.Where(x => x.EID == eid).FirstOrDefault();
            if (jc_hc_curent == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_curent);
        }

        // GET: Calls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EID,TYCOD,SUB_TYCOD,UDTS,XDTS,ESTNUM,EDIRPRE,EFEANME,EFEATYP,UNIT_COUNT,LOI_SENT,HC_SENT,AG_ID,LOI_EVAL,UNIT_EVAL,TYPE_EVAL,NUM_1,XSTREET1,XSTREET2,ESZ,COMMENTS,AD_TS")] JC_HC_CURENT jC_HC_CURENT)
        {
            if (ModelState.IsValid)
            {
                db.JC_HC_CURENT.Add(jC_HC_CURENT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jC_HC_CURENT);
        }

        // GET: Calls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_CURENT jC_HC_CURENT = db.JC_HC_CURENT.Find(id);
            if (jC_HC_CURENT == null)
            {
                return HttpNotFound();
            }
            return View(jC_HC_CURENT);
        }

        // POST: Calls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EID,TYCOD,SUB_TYCOD,UDTS,XDTS,ESTNUM,EDIRPRE,EFEANME,EFEATYP,UNIT_COUNT,LOI_SENT,HC_SENT,AG_ID,LOI_EVAL,UNIT_EVAL,TYPE_EVAL,NUM_1,XSTREET1,XSTREET2,ESZ,COMMENTS,AD_TS")] JC_HC_CURENT jC_HC_CURENT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jC_HC_CURENT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jC_HC_CURENT);
        }

        // GET: Calls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_CURENT jC_HC_CURENT = db.JC_HC_CURENT.Find(id);
            if (jC_HC_CURENT == null)
            {
                return HttpNotFound();
            }
            return View(jC_HC_CURENT);
        }

        // POST: Calls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JC_HC_CURENT jC_HC_CURENT = db.JC_HC_CURENT.Find(id);
            db.JC_HC_CURENT.Remove(jC_HC_CURENT);
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
