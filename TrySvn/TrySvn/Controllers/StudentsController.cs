using System;
using System.Web.Mvc;

namespace TrySvn.Controllers
{
	/// <summary>
	/// Description of StudentsController.
	/// </summary>
	public class StudentsController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Details(int id)
		{
			return View();
		}
		
		public ActionResult Create()
		{
			return View();
		}
		
		[HttpPost]
		public ActionResult Create(FormCollection values)
		{
			return View();
		}
		
		public ActionResult Edit(int id)
		{
			return View();
		}
		
		[HttpPost]
		public ActionResult Edit(int id, FormCollection values)
		{
			return View();
		}
		
		public ActionResult Delete(int id)
		{
			return View();
		}
		
		public ActionResult Show(String firstName, String lastName, String password){
			ViewBag.Username = firstName + " " + lastName;
			return View();
		}
	}
}