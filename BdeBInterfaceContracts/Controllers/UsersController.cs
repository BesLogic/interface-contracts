using BdeBInterfaceContracts.Models;
using BdeBInterfaceContracts.Repositories;
using System.Web.Mvc;

namespace BdeBInterfaceContracts.Controllers
{
	public class UsersController : Controller
	{
		public ActionResult Index(OrderBy orderBy = OrderBy.Id)
		{
			var users = new UserRepository();
			return View(users);
		}
	}
}
