using Microsoft.AspNetCore.Mvc;

namespace CarBook.Web.UI.Controllers
{
	public class AboutContoller : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
