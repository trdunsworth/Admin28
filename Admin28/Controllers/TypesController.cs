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
    public class TypesController : Controller
    {
        private HCEntities db = new HCEntities();

        // GET: Types
        public ActionResult Index()
        {
            return View(db.JC_HC_TYPES.OrderBy(JC_HC_TYPES => JC_HC_TYPES.ID).ToList());
        }

        // GET: Types/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_TYPES jc_hc_types = db.JC_HC_TYPES.Find(id);
            if (jc_hc_types == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_types);
        }

        // GET: Types/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Types/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TYCOD,SUB_TYCOD,AGENCY,PRIORITY,UN_CNT,ALWYS_SND,NEVR_SND,NOT4PUB")] JC_HC_TYPES jc_hc_types)
        {
            if (ModelState.IsValid)
            {
                db.JC_HC_TYPES.Add(jc_hc_types);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jc_hc_types);
        }

        // GET: Types/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_TYPES jc_hc_types = db.JC_HC_TYPES.Find(id);
            if (jc_hc_types == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_types);
        }

        // POST: Types/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TYCOD,SUB_TYCOD,AGENCY,PRIORITY,UN_CNT,ALWYS_SND,NEVR_SND,NOT4PUB")] JC_HC_TYPES jc_hc_types)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jc_hc_types).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jc_hc_types);
        }

        // GET: Types/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_TYPES jc_hc_types = db.JC_HC_TYPES.Find(id);
            if (jc_hc_types == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_types);
        }

        // POST: Types/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JC_HC_TYPES jc_hc_types = db.JC_HC_TYPES.Find(id);
            db.JC_HC_TYPES.Remove(jc_hc_types);
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
