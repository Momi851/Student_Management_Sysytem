using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Student_Management_Sysytem.DataContext;
using Student_Management_Sysytem.Models;

namespace Student_Management_Sysytem.Controllers
{

    
    public class Enroll_NowController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: Enroll_Now
        public ActionResult Index()
        {
            var enrollment = db.Enrollment.Include(e => e.Classes).Include(e => e.Sections);
            return View(enrollment.ToList());
        }

        // GET: Enroll_Now/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enroll_Now enroll_Now = db.Enrollment.Find(id);
            if (enroll_Now == null)
            {
                return HttpNotFound();
            }
            return View(enroll_Now);
        }

        // GET: Enroll_Now/Create
        public ActionResult Create()
        {
            ViewBag.Class_ID = new SelectList(db._Class, "Class_ID", "_Class");
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Section_Name");
            return View();
        }

        // POST: Enroll_Now/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Enroll_ID,Student_Name,SectionId,Class_ID,phone,Address")] Enroll_Now enroll_Now)
        {
            if (ModelState.IsValid)
            {
                db.Enrollment.Add(enroll_Now);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Class_ID = new SelectList(db._Class, "Class_ID", "_Class", enroll_Now.Class_ID);
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Section_Name", enroll_Now.SectionId);
            return View(enroll_Now);
        }

        // GET: Enroll_Now/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enroll_Now enroll_Now = db.Enrollment.Find(id);
            if (enroll_Now == null)
            {
                return HttpNotFound();
            }
            ViewBag.Class_ID = new SelectList(db._Class, "Class_ID", "_Class", enroll_Now.Class_ID);
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Section_Name", enroll_Now.SectionId);
            return View(enroll_Now);
        }

        // POST: Enroll_Now/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Enroll_ID,Student_Name,SectionId,Class_ID,phone,Address")] Enroll_Now enroll_Now)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enroll_Now).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Class_ID = new SelectList(db._Class, "Class_ID", "_Class", enroll_Now.Class_ID);
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Section_Name", enroll_Now.SectionId);
            return View(enroll_Now);
        }

        // GET: Enroll_Now/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enroll_Now enroll_Now = db.Enrollment.Find(id);
            if (enroll_Now == null)
            {
                return HttpNotFound();
            }
            return View(enroll_Now);
        }

        // POST: Enroll_Now/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Enroll_Now enroll_Now = db.Enrollment.Find(id);
            db.Enrollment.Remove(enroll_Now);
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
