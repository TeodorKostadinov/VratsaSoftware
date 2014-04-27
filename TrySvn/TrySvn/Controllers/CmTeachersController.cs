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
    public class CmTeachersController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /CmTeachers/

        public ViewResult Index()
        {
            return View(context.CmTeachers.Include(cmteacher => cmteacher.user).Include(cmteacher => cmteacher.clUniversity).ToList());
        }

        //
        // GET: /CmTeachers/Details/5

        public ViewResult Details(int id)
        {
            CmTeacher cmteacher = context.CmTeachers.Single(x => x.ID == id);
            return View(cmteacher);
        }

        //
        // GET: /CmTeachers/Create

        public ActionResult Create()
        {
            ViewBag.Possibleusers = context.Users;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View();
        } 

        //
        // POST: /CmTeachers/Create

        [HttpPost]
        public ActionResult Create(CmTeacher cmteacher)
        {
            if (ModelState.IsValid)
            {
                context.CmTeachers.Add(cmteacher);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.Possibleusers = context.Users;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View(cmteacher);
        }
        
        //
        // GET: /CmTeachers/Edit/5
 
        public ActionResult Edit(int id)
        {
            CmTeacher cmteacher = context.CmTeachers.Single(x => x.ID == id);
            ViewBag.Possibleusers = context.Users;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View(cmteacher);
        }

        //
        // POST: /CmTeachers/Edit/5

        [HttpPost]
        public ActionResult Edit(CmTeacher cmteacher)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cmteacher).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Possibleusers = context.Users;
            ViewBag.PossibleclUniversities = context.ClUniversities;
            return View(cmteacher);
        }

        //
        // GET: /CmTeachers/Delete/5
 
        public ActionResult Delete(int id)
        {
            CmTeacher cmteacher = context.CmTeachers.Single(x => x.ID == id);
            return View(cmteacher);
        }

        //
        // POST: /CmTeachers/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CmTeacher cmteacher = context.CmTeachers.Single(x => x.ID == id);
            context.CmTeachers.Remove(cmteacher);
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