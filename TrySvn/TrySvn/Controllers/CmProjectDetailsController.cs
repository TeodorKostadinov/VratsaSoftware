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
    public class CmProjectDetailsController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /CmProjectDetails/

        public ViewResult Index()
        {
            return View(context.CmProjectDetails.Include(cmprojectdetail => cmprojectdetail.cmProject).Include(cmprojectdetail => cmprojectdetail.cmStudentSubject).ToList());
        }

        //
        // GET: /CmProjectDetails/Details/5

        public ViewResult Details(int id)
        {
            CmProjectDetail cmprojectdetail = context.CmProjectDetails.Single(x => x.ID == id);
            return View(cmprojectdetail);
        }

        //
        // GET: /CmProjectDetails/Create

        public ActionResult Create()
        {
            ViewBag.PossiblecmProjects = context.CmProjects;
            ViewBag.PossiblecmStudentSubjects = context.CmStudentSubjects;
            return View();
        } 

        //
        // POST: /CmProjectDetails/Create

        [HttpPost]
        public ActionResult Create(CmProjectDetail cmprojectdetail)
        {
            if (ModelState.IsValid)
            {
                context.CmProjectDetails.Add(cmprojectdetail);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossiblecmProjects = context.CmProjects;
            ViewBag.PossiblecmStudentSubjects = context.CmStudentSubjects;
            return View(cmprojectdetail);
        }
        
        //
        // GET: /CmProjectDetails/Edit/5
 
        public ActionResult Edit(int id)
        {
            CmProjectDetail cmprojectdetail = context.CmProjectDetails.Single(x => x.ID == id);
            ViewBag.PossiblecmProjects = context.CmProjects;
            ViewBag.PossiblecmStudentSubjects = context.CmStudentSubjects;
            return View(cmprojectdetail);
        }

        //
        // POST: /CmProjectDetails/Edit/5

        [HttpPost]
        public ActionResult Edit(CmProjectDetail cmprojectdetail)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cmprojectdetail).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossiblecmProjects = context.CmProjects;
            ViewBag.PossiblecmStudentSubjects = context.CmStudentSubjects;
            return View(cmprojectdetail);
        }

        //
        // GET: /CmProjectDetails/Delete/5
 
        public ActionResult Delete(int id)
        {
            CmProjectDetail cmprojectdetail = context.CmProjectDetails.Single(x => x.ID == id);
            return View(cmprojectdetail);
        }

        //
        // POST: /CmProjectDetails/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CmProjectDetail cmprojectdetail = context.CmProjectDetails.Single(x => x.ID == id);
            context.CmProjectDetails.Remove(cmprojectdetail);
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