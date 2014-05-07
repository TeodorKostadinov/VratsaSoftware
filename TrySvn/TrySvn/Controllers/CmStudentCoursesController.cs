using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrySvn.Models;

namespace TrySvn.Controllers
{   
    public class CmStudentCoursesController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /CmStudentCourses/

        public ViewResult Index()
        {
            return View(context.CmStudentCourses.Include(cmstudentcourse => cmstudentcourse.cmStudent).Include(cmstudentcourse => cmstudentcourse.clSubject).Include(cmstudentcourse => cmstudentcourse.cmTeacher).ToList());
        }

        //
        // GET: /CmStudentCourses/Details/5

        public ViewResult Details(int id)
        {
            CmStudentCourse cmstudentcourse = context.CmStudentCourses.Single(x => x.ID == id);
            return View(cmstudentcourse);
        }

        //
        // GET: /CmStudentCourses/Create

        public ActionResult Create()
        {
            ViewBag.PossiblecmStudents = context.CmStudents;
            ViewBag.PossibleclSubjects = context.ClSubjects;
            ViewBag.PossiblecmTeachers = context.CmTeachers;
            return View();
        } 

        //
        // POST: /CmStudentCourses/Create

        [HttpPost]
        public ActionResult Create(CmStudentCourse cmstudentcourse)
        {
            if (ModelState.IsValid)
            {
                context.CmStudentCourses.Add(cmstudentcourse);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossiblecmStudents = context.CmStudents;
            ViewBag.PossibleclSubjects = context.ClSubjects;
            ViewBag.PossiblecmTeachers = context.CmTeachers;
            return View(cmstudentcourse);
        }
        
        //
        // GET: /CmStudentCourses/Edit/5
 
        public ActionResult Edit(int id)
        {
            CmStudentCourse cmstudentcourse = context.CmStudentCourses.Single(x => x.ID == id);
            ViewBag.PossiblecmStudents = context.CmStudents;
            ViewBag.PossibleclSubjects = context.ClSubjects;
            ViewBag.PossiblecmTeachers = context.CmTeachers;
            return View(cmstudentcourse);
        }

        //
        // POST: /CmStudentCourses/Edit/5

        [HttpPost]
        public ActionResult Edit(CmStudentCourse cmstudentcourse)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cmstudentcourse).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossiblecmStudents = context.CmStudents;
            ViewBag.PossibleclSubjects = context.ClSubjects;
            ViewBag.PossiblecmTeachers = context.CmTeachers;
            return View(cmstudentcourse);
        }

        //
        // GET: /CmStudentCourses/Delete/5
 
        public ActionResult Delete(int id)
        {
            CmStudentCourse cmstudentcourse = context.CmStudentCourses.Single(x => x.ID == id);
            return View(cmstudentcourse);
        }

        //
        // POST: /CmStudentCourses/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CmStudentCourse cmstudentcourse = context.CmStudentCourses.Single(x => x.ID == id);
            context.CmStudentCourses.Remove(cmstudentcourse);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}