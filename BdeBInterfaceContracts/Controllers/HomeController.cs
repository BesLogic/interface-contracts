using System.Web.Mvc;

namespace BdeBInterfaceContracts.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
