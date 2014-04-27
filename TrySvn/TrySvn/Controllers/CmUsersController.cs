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
    public class CmUsersController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /CmUsers/

        public ViewResult Index()
        {
            return View(context.CmUsers.ToList());
        }

        //
        // GET: /CmUsers/Details/5

        public ViewResult Details(int id)
        {
            CmUser cmuser = context.CmUsers.Single(x => x.ID == id);
            return View(cmuser);
        }

        //
        // GET: /CmUsers/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /CmUsers/Create

        [HttpPost]
        public ActionResult Create(CmUser cmuser)
        {
            if (ModelState.IsValid)
            {
                context.CmUsers.Add(cmuser);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(cmuser);
        }
        
        //
        // GET: /CmUsers/Edit/5
 
        public ActionResult Edit(int id)
        {
            CmUser cmuser = context.CmUsers.Single(x => x.ID == id);
            return View(cmuser);
        }

        //
        // POST: /CmUsers/Edit/5

        [HttpPost]
        public ActionResult Edit(CmUser cmuser)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cmuser).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cmuser);
        }

        //
        // GET: /CmUsers/Delete/5
 
        public ActionResult Delete(int id)
        {
            CmUser cmuser = context.CmUsers.Single(x => x.ID == id);
            return View(cmuser);
        }

        //
        // POST: /CmUsers/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CmUser cmuser = context.CmUsers.Single(x => x.ID == id);
            context.CmUsers.Remove(cmuser);
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