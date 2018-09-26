using BdeBInterfaceContracts.Models;
using BdeBInterfaceContracts.Repositories;
using System.Web.Mvc;
using BdeBInterfaceContracts.Services;

namespace BdeBInterfaceContracts.Controllers
{
	public class UsersController : Controller
	{
		public ActionResult Index(OrderBy orderBy = OrderBy.Id)
		{
			var users = new UserRepository();
		    if (orderBy == OrderBy.CreationDate)
		    {
		        var orderingService = new OrderingService();
		        var orderedUsers = orderingService.OrderByCreationDate(users);
		        return View(orderedUsers);
		    }
			return View(users);
		}
	}
}
