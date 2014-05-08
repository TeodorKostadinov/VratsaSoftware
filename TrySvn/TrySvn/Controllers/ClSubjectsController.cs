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
    public class ClSubjectsController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /ClSubjects/

        public ViewResult Index()
        {
            return View(context.ClSubjects.Include(clsubject => clsubject.clCategory).Include(clsubject => clsubject.clUniversity).ToList());
        }

        //
        // GET: /ClSubjects/Details/5

        public ViewResult Details(int id)
        {
            ClSubject clsubject = context.ClSubjects.Single(x => x.ID == id);
            return View(clsubject);
        }

        //
        // GET: /ClSubjects/Create

        public ActionResult Create()
        {
            ViewBag.PossibleclCategories = context.ClCategories;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View();
        } 

        //
        // POST: /ClSubjects/Create

        [HttpPost]
        public ActionResult Create(ClSubject clsubject)
        {
            if (ModelState.IsValid)
            {
                context.ClSubjects.Add(clsubject);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleclCategories = context.ClCategories;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View(clsubject);
        }
        
        //
        // GET: /ClSubjects/Edit/5
 
        public ActionResult Edit(int id)
        {
            ClSubject clsubject = context.ClSubjects.Single(x => x.ID == id);
            ViewBag.PossibleclCategories = context.ClCategories;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View(clsubject);
        }

        //
        // POST: /ClSubjects/Edit/5

        [HttpPost]
        public ActionResult Edit(ClSubject clsubject)
        {
            if (ModelState.IsValid)
            {
                context.Entry(clsubject).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleclCategories = context.ClCategories;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View(clsubject);
        }

        //
        // GET: /ClSubjects/Delete/5
 
        public ActionResult Delete(int id)
        {
            ClSubject clsubject = context.ClSubjects.Single(x => x.ID == id);
            return View(clsubject);
        }

        //
        // POST: /ClSubjects/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ClSubject clsubject = context.ClSubjects.Single(x => x.ID == id);
            context.ClSubjects.Remove(clsubject);
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