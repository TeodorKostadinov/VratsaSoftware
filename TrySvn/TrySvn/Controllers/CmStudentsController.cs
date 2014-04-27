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
    public class CmStudentsController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /CmStudents/

        public ViewResult Index()
        {
            return View(context.CmStudents.Include(cmstudent => cmstudent.user).Include(cmstudent => cmstudent.clUniversity).ToList());
        }

        //
        // GET: /CmStudents/Details/5

        public ViewResult Details(int id)
        {
            CmStudent cmstudent = context.CmStudents.Single(x => x.ID == id);
            return View(cmstudent);
        }

        //
        // GET: /CmStudents/Create

        public ActionResult Create()
        {
            ViewBag.Possibleusers = context.Users;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View();
        } 

        //
        // POST: /CmStudents/Create

        [HttpPost]
        public ActionResult Create(CmStudent cmstudent)
        {
            if (ModelState.IsValid)
            {
                context.CmStudents.Add(cmstudent);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.Possibleusers = context.Users;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View(cmstudent);
        }
        
        //
        // GET: /CmStudents/Edit/5
 
        public ActionResult Edit(int id)
        {
            CmStudent cmstudent = context.CmStudents.Single(x => x.ID == id);
            ViewBag.Possibleusers = context.Users;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View(cmstudent);
        }

        //
        // POST: /CmStudents/Edit/5

        [HttpPost]
        public ActionResult Edit(CmStudent cmstudent)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cmstudent).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Possibleusers = context.Users;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View(cmstudent);
        }

        //
        // GET: /CmStudents/Delete/5
 
        public ActionResult Delete(int id)
        {
            CmStudent cmstudent = context.CmStudents.Single(x => x.ID == id);
            return View(cmstudent);
        }

        //
        // POST: /CmStudents/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CmStudent cmstudent = context.CmStudents.Single(x => x.ID == id);
            context.CmStudents.Remove(cmstudent);
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