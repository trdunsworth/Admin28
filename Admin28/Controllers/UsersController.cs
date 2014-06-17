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
    public class UsersController : Controller
    {
        private HCEntities db = new HCEntities();

        public ActionResult SelectBoolean()
        {
            List<SelectListItem> booleans = new List<SelectListItem>();
            booleans.Add(new SelectListItem { Text = "T", Value = "T" });
            booleans.Add(new SelectListItem { Text = "F", Value = "F" });

            ViewBag.BooleanType = booleans;

            return View();
        }

        public ActionResult SelectAgency()
        {
            List<SelectListItem> agencies = new List<SelectListItem>();
            agencies.Add(new SelectListItem { Text = "FWPD", Value = "FWPD" });
            agencies.Add(new SelectListItem { Text = "GDPD", Value = "GDPD" });
            agencies.Add(new SelectListItem { Text = "JCSO", Value = "JCSO", Selected = true });
            agencies.Add(new SelectListItem { Text = "LQPD", Value = "LQPD" });
            agencies.Add(new SelectListItem { Text = "LWPD", Value = "LWPD" });
            agencies.Add(new SelectListItem { Text = "LXPD", Value = "LXPD" });
            agencies.Add(new SelectListItem { Text = "MHPD", Value = "MHPD" });
            agencies.Add(new SelectListItem { Text = "MRPD", Value = "MRPD" });
            agencies.Add(new SelectListItem { Text = "MSPD", Value = "MSPD" });
            agencies.Add(new SelectListItem { Text = "OPD", Value = "OPD" });
            agencies.Add(new SelectListItem { Text = "OPPD", Value = "OPPD" });
            agencies.Add(new SelectListItem { Text = "PKPD", Value = "PKPD" });
            agencies.Add(new SelectListItem { Text = "PVPD", Value = "PVPD" });
            agencies.Add(new SelectListItem { Text = "RPPD", Value = "RPPD" });
            agencies.Add(new SelectListItem { Text = "SHPD", Value = "SHPD" });
            agencies.Add(new SelectListItem { Text = "SHWPD", Value = "SHWPD" });
            agencies.Add(new SelectListItem { Text = "WWPD", Value = "WWPD" });
            agencies.Add(new SelectListItem { Text = "OTHER", Value = "OTHER" });

            ViewBag.AgencyType = agencies;

            return View();
        }
        
        // GET: Users
        public ActionResult Index(string searchString)
        {
            var users = from u in db.JC_HC_USERS
                        select u;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.LNAME.Contains(searchString.ToUpper()));
            }

            return View(users.OrderBy(JC_HC_USERS => JC_HC_USERS.ID).ToList());
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_USERS jc_hc_users = db.JC_HC_USERS.Find(id);
            if (jc_hc_users == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_users);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LNAME,FNAME,AG_ID,EMAIL,OOF,LOI_GRPS,ESZ,ZIP,LEO,ZIP2,ZIP3,RECD1,RECD2,RECD3,RECD4,RECD5,RECD6")] JC_HC_USERS jc_hc_users)
        {
            if (ModelState.IsValid)
            {
                db.JC_HC_USERS.Add(jc_hc_users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jc_hc_users);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_USERS jc_hc_users = db.JC_HC_USERS.Find(id);
            if (jc_hc_users == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_users);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LNAME,FNAME,AG_ID,EMAIL,OOF,LOI_GRPS,ESZ,ZIP,LEO,ZIP2,ZIP3,RECD1,RECD2,RECD3,RECD4,RECD5,RECD6")] JC_HC_USERS jc_hc_users)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jc_hc_users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jc_hc_users);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JC_HC_USERS jc_hc_users = db.JC_HC_USERS.Find(id);
            if (jc_hc_users == null)
            {
                return HttpNotFound();
            }
            return View(jc_hc_users);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JC_HC_USERS jc_hc_users = db.JC_HC_USERS.Find(id);
            db.JC_HC_USERS.Remove(jc_hc_users);
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
