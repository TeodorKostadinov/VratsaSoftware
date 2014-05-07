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
    public class CmCompanyRepresentativesController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /CmCompanyRepresentatives/

        public ViewResult Index()
        {
            return View(context.CmCompanyRepresentatives.Include(cmcompanyrepresentative => cmcompanyrepresentative.user).Include(cmcompanyrepresentative => cmcompanyrepresentative.cmCompany).ToList());
        }

        //
        // GET: /CmCompanyRepresentatives/Details/5

        public ViewResult Details(int id)
        {
            CmCompanyRepresentative cmcompanyrepresentative = context.CmCompanyRepresentatives.Single(x => x.ID == id);
            return View(cmcompanyrepresentative);
        }

        //
        // GET: /CmCompanyRepresentatives/Create

        public ActionResult Create()
        {
            ViewBag.Possibleusers = context.Users;
            ViewBag.PossiblecmCompanies = context.CmCompanies;
            return View();
        } 

        //
        // POST: /CmCompanyRepresentatives/Create

        [HttpPost]
        public ActionResult Create(CmCompanyRepresentative cmcompanyrepresentative)
        {
            if (ModelState.IsValid)
            {
                context.CmCompanyRepresentatives.Add(cmcompanyrepresentative);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.Possibleusers = context.Users;
            ViewBag.PossiblecmCompanies = context.CmCompanies;
            return View(cmcompanyrepresentative);
        }
        
        //
        // GET: /CmCompanyRepresentatives/Edit/5
 
        public ActionResult Edit(int id)
        {
            CmCompanyRepresentative cmcompanyrepresentative = context.CmCompanyRepresentatives.Single(x => x.ID == id);
            ViewBag.Possibleusers = context.Users;
            ViewBag.PossiblecmCompanies = context.CmCompanies;
            return View(cmcompanyrepresentative);
        }

        //
        // POST: /CmCompanyRepresentatives/Edit/5

        [HttpPost]
        public ActionResult Edit(CmCompanyRepresentative cmcompanyrepresentative)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cmcompanyrepresentative).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Possibleusers = context.Users;
            ViewBag.PossiblecmCompanies = context.CmCompanies;
            return View(cmcompanyrepresentative);
        }

        //
        // GET: /CmCompanyRepresentatives/Delete/5
 
        public ActionResult Delete(int id)
        {
            CmCompanyRepresentative cmcompanyrepresentative = context.CmCompanyRepresentatives.Single(x => x.ID == id);
            return View(cmcompanyrepresentative);
        }

        //
        // POST: /CmCompanyRepresentatives/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CmCompanyRepresentative cmcompanyrepresentative = context.CmCompanyRepresentatives.Single(x => x.ID == id);
            context.CmCompanyRepresentatives.Remove(cmcompanyrepresentative);
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