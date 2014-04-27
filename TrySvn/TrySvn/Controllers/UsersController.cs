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
    public class UsersController : Controller
    {
        private TrySvnContext context = new TrySvnContext();

        //
        // GET: /Users/

        public ViewResult Index()
        {
            return View(context.Users.ToList());
        }
        
        public ActionResult UserCustomView()
        {
        	return View();
        }
        
        [HttpPost]
        public ActionResult UserCustomView(User userModel, String user, string pass)
        {        	
        	System.Diagnostics.Debug.WriteLine("are we in the game?");
        	
        	var userTry = context.Users.Where(s => s.Email.Contains(user));
        	
        	
        	
        	//IQueryable<User> result = userTry.SingleOrDefault;
        	
//        	if (result != null)
//        	{
//        		//results = String.Format("Welcome, {0}!", userTry);
//        		//return RedirectToAction("Details", new { id = userTry.ID });  
//        		return RedirectToAction("Create");
//        	}
//        	else
//        	{
//        		return RedirectToAction("Index" );
//        	}      	
        	
        	return View(userTry);
        }


        //
        // GET: /Users/Details/5

        public ViewResult Details(int id)
        {
            User user = context.Users.Single(x => x.ID == id);
            return View(user);
        }

        //
        // GET: /Users/Create

        public ActionResult Create()
        {
            System.Diagnostics.Debug.WriteLine("GET create?");
        	return View();
        } 

        //
        // POST: /Users/Create

        [HttpPost]
        public ActionResult Create(User user)
        {
        	System.Diagnostics.Debug.WriteLine("POST create");
        
            if (ModelState.IsValid)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(user);
        }
        
        //
        // GET: /Users/Edit/5
 
        public ActionResult Edit(int id)
        {
            User user = context.Users.Single(x => x.ID == id);
            return View(user);
        }

        //
        // POST: /Users/Edit/5

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //
        // GET: /Users/Delete/5
 
        public ActionResult Delete(int id)
        {
            User user = context.Users.Single(x => x.ID == id);
            return View(user);
        }

        //
        // POST: /Users/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = context.Users.Single(x => x.ID == id);
            context.Users.Remove(user);
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
        
        #region Private Methods
        
        private bool IsValidUser(string username, string pass)
        {
        	// Check whether we have record for this user
        }
        
        #endregion // Private Methods
    }
}