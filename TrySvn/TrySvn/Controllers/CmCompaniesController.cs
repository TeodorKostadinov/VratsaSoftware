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
    public class CmCompaniesController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /CmCompanies/

        public ViewResult Index()
        {
            return View(context.CmCompanies.Include(cmcompany => cmcompany.clCategory).ToList());
        }

        //
        // GET: /CmCompanies/Details/5

        public ViewResult Details(int id)
        {
            CmCompany cmcompany = context.CmCompanies.Single(x => x.ID == id);
            return View(cmcompany);
        }

        //
        // GET: /CmCompanies/Create

        public ActionResult Create()
        {
            ViewBag.PossibleclCategories = context.ClCategories;
            return View();
        } 

        //
        // POST: /CmCompanies/Create

        [HttpPost]
        public ActionResult Create(CmCompany cmcompany)
        {
            if (ModelState.IsValid)
            {
                context.CmCompanies.Add(cmcompany);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.PossibleclCategories = context.ClCategories;
            return View(cmcompany);
        }
        
        //
        // GET: /CmCompanies/Edit/5
 
        public ActionResult Edit(int id)
        {
            CmCompany cmcompany = context.CmCompanies.Single(x => x.ID == id);
            ViewBag.PossibleclCategories = context.ClCategories;
            return View(cmcompany);
        }

        //
        // POST: /CmCompanies/Edit/5

        [HttpPost]
        public ActionResult Edit(CmCompany cmcompany)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cmcompany).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleclCategories = context.ClCategories;
            return View(cmcompany);
        }

        //
        // GET: /CmCompanies/Delete/5
 
        public ActionResult Delete(int id)
        {
            CmCompany cmcompany = context.CmCompanies.Single(x => x.ID == id);
            return View(cmcompany);
        }

        //
        // POST: /CmCompanies/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CmCompany cmcompany = context.CmCompanies.Single(x => x.ID == id);
            context.CmCompanies.Remove(cmcompany);
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