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
    
    public class Assign_CourseController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: Assign_Course
        public ActionResult Index()
        {
            var assign_Courses = db.Assign_Courses.Include(a => a._Courses).Include(a => a.Teachers);
            return View(assign_Courses.ToList());
        }

        // GET: Assign_Course/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assign_Course assign_Course = db.Assign_Courses.Find(id);
            if (assign_Course == null)
            {
                return HttpNotFound();
            }
            return View(assign_Course);
        }

        // GET: Assign_Course/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Coursess, "SubjectId", "Subject");
            ViewBag.TeacherId = new SelectList(db.Teachers, "Teacher_Id", "Teacher_Name");
            return View();
        }

        // POST: Assign_Course/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TeacherId,CourseId")] Assign_Course assign_Course)
        {
            if (ModelState.IsValid)
            {
                db.Assign_Courses.Add(assign_Course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Coursess, "SubjectId", "Subject", assign_Course.CourseId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "Teacher_Id", "Teacher_Name", assign_Course.TeacherId);
            return View(assign_Course);
        }

        // GET: Assign_Course/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assign_Course assign_Course = db.Assign_Courses.Find(id);
            if (assign_Course == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Coursess, "SubjectId", "Subject", assign_Course.CourseId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "Teacher_Id", "Teacher_Name", assign_Course.TeacherId);
            return View(assign_Course);
        }

        // POST: Assign_Course/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TeacherId,CourseId")] Assign_Course assign_Course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assign_Course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Coursess, "SubjectId", "Subject", assign_Course.CourseId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "Teacher_Id", "Teacher_Name", assign_Course.TeacherId);
            return View(assign_Course);
        }

        // GET: Assign_Course/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assign_Course assign_Course = db.Assign_Courses.Find(id);
            if (assign_Course == null)
            {
                return HttpNotFound();
            }
            return View(assign_Course);
        }

        // POST: Assign_Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assign_Course assign_Course = db.Assign_Courses.Find(id);
            db.Assign_Courses.Remove(assign_Course);
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
