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
    public class FeeBillsController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: FeeBills
        public ActionResult Index()
        {
            var feeBills = db.FeeBills.Include(f => f.Classes).Include(f => f.Sections);
            return View(feeBills.ToList());
        }

        // GET: FeeBills/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeeBill feeBill = db.FeeBills.Find(id);
            if (feeBill == null)
            {
                return HttpNotFound();
            }
            return View(feeBill);
        }

        // GET: FeeBills/Create
        public ActionResult Create()
        {
            ViewBag.Class_ID = new SelectList(db._Class, "Class_ID", "_Class");
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Section_Name");
            return View();
        }

        // POST: FeeBills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Fee_ID,Student_Name,SectionId,Class_ID,Admission_Fee,Monthly_Fee")] FeeBill feeBill)
        {
            if (ModelState.IsValid)
            {
                db.FeeBills.Add(feeBill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Class_ID = new SelectList(db._Class, "Class_ID", "_Class", feeBill.Class_ID);
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Section_Name", feeBill.SectionId);
            return View(feeBill);
        }

        // GET: FeeBills/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeeBill feeBill = db.FeeBills.Find(id);
            if (feeBill == null)
            {
                return HttpNotFound();
            }
            ViewBag.Class_ID = new SelectList(db._Class, "Class_ID", "_Class", feeBill.Class_ID);
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Section_Name", feeBill.SectionId);
            return View(feeBill);
        }

        // POST: FeeBills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Fee_ID,Student_Name,SectionId,Class_ID,Admission_Fee,Monthly_Fee")] FeeBill feeBill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feeBill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Class_ID = new SelectList(db._Class, "Class_ID", "_Class", feeBill.Class_ID);
            ViewBag.SectionId = new SelectList(db.Sections, "SectionId", "Section_Name", feeBill.SectionId);
            return View(feeBill);
        }

        // GET: FeeBills/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeeBill feeBill = db.FeeBills.Find(id);
            if (feeBill == null)
            {
                return HttpNotFound();
            }
            return View(feeBill);
        }

        // POST: FeeBills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FeeBill feeBill = db.FeeBills.Find(id);
            db.FeeBills.Remove(feeBill);
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
