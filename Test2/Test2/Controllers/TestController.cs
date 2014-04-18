using System;
using System.Web.Mvc;

namespace Test2.Controllers
{
	/// <summary>
	/// Description of TestController.
	/// </summary>
	public class TestController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}