using BdeBInterfaceContracts.Models;
using BdeBInterfaceContracts.Repositories;
using System.Web.Mvc;

namespace BdeBInterfaceContracts.Controllers
{
	public class OrdersController : Controller
	{
		public ActionResult Index(OrderBy orderBy = OrderBy.Id)
		{
			var orders = new OrderRepository();
			return View(orders);
		}
	}
}
