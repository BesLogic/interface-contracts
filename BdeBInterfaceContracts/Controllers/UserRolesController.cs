using BdeBInterfaceContracts.Repositories;
using System.Web.Mvc;

namespace BdeBInterfaceContracts.Controllers
{
	public class UserRolesController : Controller
	{
		public ActionResult Index()
		{
			var userRoles = new UserRoleRepository();
			return View(userRoles);
		}
	}
}
