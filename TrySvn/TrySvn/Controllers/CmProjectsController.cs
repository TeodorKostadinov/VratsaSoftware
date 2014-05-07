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
    public class CmProjectsController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /CmProjects/

        public ViewResult Index()
        {
            return View(context.CmProjects.Include(cmproject => cmproject.cmCompany).ToList());
        }

        //
        // GET: /CmProjects/Details/5

        public ViewResult Details(int id)
        {
            CmProject cmproject = context.CmProjects.Single(x => x.ID == id);
            return View(cmproject);
        }

        //
        // GET: /CmProjects/Create

        public ActionResult Create()
        {
            ViewBag.PossiblecmCompanies = context.CmCompanies;
            ViewBag.PossibleclCategories = context.ClCategories;
            return View();
        } 

        //
        // POST: /CmProjects/Create

        [HttpPost]
        public ActionResult Create(CmProject cmproject)
        {
            if (ModelState.IsValid)
            {
                context.CmProjects.Add(cmproject);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossiblecmCompanies = context.CmCompanies;
            ViewBag.PossibleclCategories = context.ClCategories;
            return View(cmproject);
        }
        
        //
        // GET: /CmProjects/Edit/5
 
        public ActionResult Edit(int id)
        {
            CmProject cmproject = context.CmProjects.Single(x => x.ID == id);
            ViewBag.PossiblecmCompanies = context.CmCompanies;
            ViewBag.PossibleclCategories = context.ClCategories;
            return View(cmproject);
        }

        //
        // POST: /CmProjects/Edit/5

        [HttpPost]
        public ActionResult Edit(CmProject cmproject)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cmproject).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossiblecmCompanies = context.CmCompanies;
            ViewBag.PossibleclCategories = context.ClCategories;
            return View(cmproject);
        }

        //
        // GET: /CmProjects/Delete/5
 
        public ActionResult Delete(int id)
        {
            CmProject cmproject = context.CmProjects.Single(x => x.ID == id);
            return View(cmproject);
        }

        //
        // POST: /CmProjects/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CmProject cmproject = context.CmProjects.Single(x => x.ID == id);
            context.CmProjects.Remove(cmproject);
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