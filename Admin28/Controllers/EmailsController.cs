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
    public class EmailsController : Controller
    {
        private HCEntities db = new HCEntities();

        // GET: Emails
        public ActionResult Index(string searchString)
        {
            var emails = from e in db.JC_HC_SENT
                         select e;

            if (!String.IsNullOrEmpty(searchString))
            {
                emails = emails.Where(s => s.NUM_1.Contains(searchString));
            }

            return View(emails.OrderByDescending(JC_HC_SENT => JC_HC_SENT.ID).ToList());
        }

        // GET: Emails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_SENT jc_hc_sent = db.JC_HC_SENT.Find(id);
            if (jc_hc_sent == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_sent);
        }

        // GET: Emails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EID,AG_ID,TYCOD,SUB_TYCOD,SENT_DT,EMAIL_SENT,NUM_1,ID")] JC_HC_SENT jc_hc_sent)
        {
            if (ModelState.IsValid)
            {
                db.JC_HC_SENT.Add(jc_hc_sent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jc_hc_sent);
        }

        // GET: Emails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_SENT jc_hc_sent = db.JC_HC_SENT.Find(id);
            if (jc_hc_sent == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_sent);
        }

        // POST: Emails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EID,AG_ID,TYCOD,SUB_TYCOD,SENT_DT,EMAIL_SENT,NUM_1,ID")] JC_HC_SENT jc_hc_sent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jc_hc_sent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jc_hc_sent);
        }

        // GET: Emails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_SENT jc_hc_sent = db.JC_HC_SENT.Find(id);
            if (jc_hc_sent == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_sent);
        }

        // POST: Emails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JC_HC_SENT jc_hc_sent = db.JC_HC_SENT.Find(id);
            db.JC_HC_SENT.Remove(jc_hc_sent);
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
