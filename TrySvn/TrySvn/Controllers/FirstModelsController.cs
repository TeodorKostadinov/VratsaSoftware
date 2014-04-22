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
    public class FirstModelsController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /FirstModels/

        public ViewResult Index()
        {
            return View(context.FirstModels.ToList());
        }

        //
        // GET: /FirstModels/Details/5

        public ViewResult Details(int id)
        {
            FirstModel firstmodel = context.FirstModels.Single(x => x.ID == id);
            return View(firstmodel);
        }

        //
        // GET: /FirstModels/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /FirstModels/Create

        [HttpPost]
        public ActionResult Create(FirstModel firstmodel)
        {
            if (ModelState.IsValid)
            {
                context.FirstModels.Add(firstmodel);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(firstmodel);
        }
        
        //
        // GET: /FirstModels/Edit/5
 
        public ActionResult Edit(int id)
        {
            FirstModel firstmodel = context.FirstModels.Single(x => x.ID == id);
            return View(firstmodel);
        }

        //
        // POST: /FirstModels/Edit/5

        [HttpPost]
        public ActionResult Edit(FirstModel firstmodel)
        {
            if (ModelState.IsValid)
            {
                context.Entry(firstmodel).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(firstmodel);
        }

        //
        // GET: /FirstModels/Delete/5
 
        public ActionResult Delete(int id)
        {
            FirstModel firstmodel = context.FirstModels.Single(x => x.ID == id);
            return View(firstmodel);
        }

        //
        // POST: /FirstModels/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            FirstModel firstmodel = context.FirstModels.Single(x => x.ID == id);
            context.FirstModels.Remove(firstmodel);
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