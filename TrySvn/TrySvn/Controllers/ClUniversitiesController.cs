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
    public class ClUniversitiesController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /ClUniversities/

        public ViewResult Index()
        {
            return View(context.ClUniversities.ToList());
        }

        //
        // GET: /ClUniversities/Details/5

        public ViewResult Details(int id)
        {
            ClUniversity cluniversity = context.ClUniversities.Single(x => x.ID == id);
            return View(cluniversity);
        }

        //
        // GET: /ClUniversities/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ClUniversities/Create

        [HttpPost]
        public ActionResult Create(ClUniversity cluniversity)
        {
            if (ModelState.IsValid)
            {
                context.ClUniversities.Add(cluniversity);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(cluniversity);
        }
        
        //
        // GET: /ClUniversities/Edit/5
 
        public ActionResult Edit(int id)
        {
            ClUniversity cluniversity = context.ClUniversities.Single(x => x.ID == id);
            return View(cluniversity);
        }

        //
        // POST: /ClUniversities/Edit/5

        [HttpPost]
        public ActionResult Edit(ClUniversity cluniversity)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cluniversity).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cluniversity);
        }

        //
        // GET: /ClUniversities/Delete/5
 
        public ActionResult Delete(int id)
        {
            ClUniversity cluniversity = context.ClUniversities.Single(x => x.ID == id);
            return View(cluniversity);
        }

        //
        // POST: /ClUniversities/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ClUniversity cluniversity = context.ClUniversities.Single(x => x.ID == id);
            context.ClUniversities.Remove(cluniversity);
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