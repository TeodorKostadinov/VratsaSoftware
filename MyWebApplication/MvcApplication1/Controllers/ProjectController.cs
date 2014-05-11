using System;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
	/// <summary>
	/// Description of ProjectsController.
	/// </summary>
	public class ProjectController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		
		public ActionResult ProjectDetails()
		{
			return View();
		}
	}
}