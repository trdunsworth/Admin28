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
    public class SubscriptionsController : Controller
    {
        private HCEntities db = new HCEntities();

        // GET: Subscriptions
        public ActionResult Index(int? searchString)
        {
            var users = from u in db.JC_HC_USR_SND
                            select u;
            if (searchString != null)
            {
                users = users.Where(s => s.USR_ID == searchString);
            }
            var jc_hc_usr_snd = db.JC_HC_USR_SND.Include(j => j.JC_HC_AGENCY).Include(j => j.JC_HC_LOI).Include(j => j.JC_HC_USERS);
            return View(users.OrderBy(JC_HC_USR_SND => JC_HC_USR_SND.ID).ToList());
        }

        // GET: Subscriptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_USR_SND jc_hc_usr_snd = db.JC_HC_USR_SND.Find(id);
            if (jc_hc_usr_snd == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_usr_snd);
        }

        // GET: Subscriptions/Create
        public ActionResult Create()
        {
            //ViewBag.AGY_ID = new SelectList(db.JC_HC_AGENCY, "ID", "AG_ID");
            //ViewBag.LOI_ID = new SelectList(db.JC_HC_LOI.OrderBy(x => x.ID), "ID", "ADDRESS");
            ViewBag.USR_ID = new SelectList(db.JC_HC_USERS.OrderBy(x => x.ID), "ID", "LNAME");
            return View();
        }

        // POST: Subscriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,USR_ID,ESZ,AGY_ID,GRP_ID,LOI_ID")] JC_HC_USR_SND jc_hc_usr_snd)
        {
            if (ModelState.IsValid)
            {
                db.JC_HC_USR_SND.Add(jc_hc_usr_snd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.AGY_ID = new SelectList(db.JC_HC_AGENCY, "ID", "AG_ID", jc_hc_usr_snd.AGY_ID);
            //ViewBag.LOI_ID = new SelectList(db.JC_HC_LOI.OrderBy(x => x.ID), "ID", "ADDRESS", jc_hc_usr_snd.LOI_ID);
            ViewBag.USR_ID = new SelectList(db.JC_HC_USERS.OrderBy(x => x.ID), "ID", "LNAME", jc_hc_usr_snd.USR_ID);
            return View(jc_hc_usr_snd);
        }

        // GET: Subscriptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_USR_SND jc_hc_usr_snd = db.JC_HC_USR_SND.Find(id);
            if (jc_hc_usr_snd == null)
            {
                return HttpNotFound();
            }
            //ViewBag.AGY_ID = new SelectList(db.JC_HC_AGENCY, "ID", "AG_ID", jc_hc_usr_snd.AGY_ID);
            //ViewBag.LOI_ID = new SelectList(db.JC_HC_LOI.OrderBy(x => x.ID), "ID", "ADDRESS", jc_hc_usr_snd.LOI_ID);
            ViewBag.USR_ID = new SelectList(db.JC_HC_USERS.OrderBy(x => x.ID), "ID", "LNAME", jc_hc_usr_snd.USR_ID);
            return View(jc_hc_usr_snd);
        }

        // POST: Subscriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,USR_ID,ESZ,AGY_ID,GRP_ID,LOI_ID")] JC_HC_USR_SND jc_hc_usr_snd)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jc_hc_usr_snd).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.AGY_ID = new SelectList(db.JC_HC_AGENCY, "ID", "AG_ID", jc_hc_usr_snd.AGY_ID);
            //ViewBag.LOI_ID = new SelectList(db.JC_HC_LOI.OrderBy(x => x.ID), "ID", "ADDRESS", jc_hc_usr_snd.LOI_ID);
            ViewBag.USR_ID = new SelectList(db.JC_HC_USERS.OrderBy(x => x.ID), "ID", "LNAME", jc_hc_usr_snd.USR_ID);
            return View(jc_hc_usr_snd);
        }

        // GET: Subscriptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_USR_SND jc_hc_usr_snd = db.JC_HC_USR_SND.Find(id);
            if (jc_hc_usr_snd == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_usr_snd);
        }

        // POST: Subscriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JC_HC_USR_SND jc_hc_usr_snd = db.JC_HC_USR_SND.Find(id);
            db.JC_HC_USR_SND.Remove(jc_hc_usr_snd);
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
