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
    public class CmStudentSubjectsController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /CmStudentSubjects/

        public ViewResult Index()
        {
            return View(context.CmStudentSubjects.Include(cmstudentsubject => cmstudentsubject.cmStudent).Include(cmstudentsubject => cmstudentsubject.clSubject).Include(cmstudentsubject => cmstudentsubject.cmTeacher).ToList());
        }

        //
        // GET: /CmStudentSubjects/Details/5

        public ViewResult Details(int id)
        {
            CmStudentSubject cmstudentsubject = context.CmStudentSubjects.Single(x => x.ID == id);
            return View(cmstudentsubject);
        }

        //
        // GET: /CmStudentSubjects/Create

        public ActionResult Create()
        {
            ViewBag.PossiblecmStudents = context.CmStudents;
            ViewBag.PossibleclSubjects = context.ClSubjects;
            ViewBag.PossiblecmTeachers = context.CmTeachers;
            return View();
        } 

        //
        // POST: /CmStudentSubjects/Create

        [HttpPost]
        public ActionResult Create(CmStudentSubject cmstudentsubject)
        {
            if (ModelState.IsValid)
            {
                context.CmStudentSubjects.Add(cmstudentsubject);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossiblecmStudents = context.CmStudents;
            ViewBag.PossibleclSubjects = context.ClSubjects;
            ViewBag.PossiblecmTeachers = context.CmTeachers;
            return View(cmstudentsubject);
        }
        
        //
        // GET: /CmStudentSubjects/Edit/5
 
        public ActionResult Edit(int id)
        {
            CmStudentSubject cmstudentsubject = context.CmStudentSubjects.Single(x => x.ID == id);
            ViewBag.PossiblecmStudents = context.CmStudents;
            ViewBag.PossibleclSubjects = context.ClSubjects;
            ViewBag.PossiblecmTeachers = context.CmTeachers;
            return View(cmstudentsubject);
        }

        //
        // POST: /CmStudentSubjects/Edit/5

        [HttpPost]
        public ActionResult Edit(CmStudentSubject cmstudentsubject)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cmstudentsubject).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossiblecmStudents = context.CmStudents;
            ViewBag.PossibleclSubjects = context.ClSubjects;
            ViewBag.PossiblecmTeachers = context.CmTeachers;
            return View(cmstudentsubject);
        }

        //
        // GET: /CmStudentSubjects/Delete/5
 
        public ActionResult Delete(int id)
        {
            CmStudentSubject cmstudentsubject = context.CmStudentSubjects.Single(x => x.ID == id);
            return View(cmstudentsubject);
        }

        //
        // POST: /CmStudentSubjects/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CmStudentSubject cmstudentsubject = context.CmStudentSubjects.Single(x => x.ID == id);
            context.CmStudentSubjects.Remove(cmstudentsubject);
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