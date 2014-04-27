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
    public class AgenciesController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /Agencies/

        public ViewResult Index()
        {
            return View(context.Agencies.ToList());
        }

        //
        // GET: /Agencies/Details/5

        public ViewResult Details(int id)
        {
            Agency agency = context.Agencies.Single(x => x.ID == id);
            return View(agency);
        }

        //
        // GET: /Agencies/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Agencies/Create

        [HttpPost]
        public ActionResult Create(Agency agency)
        {
            if (ModelState.IsValid)
            {
                context.Agencies.Add(agency);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(agency);
        }
        
        //
        // GET: /Agencies/Edit/5
 
        public ActionResult Edit(int id)
        {
            Agency agency = context.Agencies.Single(x => x.ID == id);
            return View(agency);
        }

        //
        // POST: /Agencies/Edit/5

        [HttpPost]
        public ActionResult Edit(Agency agency)
        {
            if (ModelState.IsValid)
            {
                context.Entry(agency).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agency);
        }

        //
        // GET: /Agencies/Delete/5
 
        public ActionResult Delete(int id)
        {
            Agency agency = context.Agencies.Single(x => x.ID == id);
            return View(agency);
        }

        //
        // POST: /Agencies/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Agency agency = context.Agencies.Single(x => x.ID == id);
            context.Agencies.Remove(agency);
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