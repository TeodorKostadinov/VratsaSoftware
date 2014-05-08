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
    public class ClCategoriesController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /ClCategories/

        public ViewResult Index()
        {
            return View(context.ClCategories.ToList());
        }

        //
        // GET: /ClCategories/Details/5

        public ViewResult Details(int id)
        {
            ClCategory clcategory = context.ClCategories.Single(x => x.ID == id);
            return View(clcategory);
        }

        //
        // GET: /ClCategories/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ClCategories/Create

        [HttpPost]
        public ActionResult Create(ClCategory clcategory)
        {
            if (ModelState.IsValid)
            {
                context.ClCategories.Add(clcategory);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(clcategory);
        }
        
        //
        // GET: /ClCategories/Edit/5
 
        public ActionResult Edit(int id)
        {
            ClCategory clcategory = context.ClCategories.Single(x => x.ID == id);
            return View(clcategory);
        }

        //
        // POST: /ClCategories/Edit/5

        [HttpPost]
        public ActionResult Edit(ClCategory clcategory)
        {
            if (ModelState.IsValid)
            {
                context.Entry(clcategory).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clcategory);
        }

        //
        // GET: /ClCategories/Delete/5
 
        public ActionResult Delete(int id)
        {
            ClCategory clcategory = context.ClCategories.Single(x => x.ID == id);
            return View(clcategory);
        }

        //
        // POST: /ClCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ClCategory clcategory = context.ClCategories.Single(x => x.ID == id);
            context.ClCategories.Remove(clcategory);
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