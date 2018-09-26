using BdeBInterfaceContracts.Models;
using BdeBInterfaceContracts.Repositories;
using System.Web.Mvc;
using BdeBInterfaceContracts.Services;

namespace BdeBInterfaceContracts.Controllers
{
	public class OrdersController : Controller
	{
		public ActionResult Index(OrderBy orderBy = OrderBy.Id)
		{
			var orders = new OrderRepository();
		    if (orderBy == OrderBy.CreationDate)
		    {
		        var orderingService = new OrderingService();
		        var orderedOrders = orderingService.OrderByCreationDate(orders);
		        return View(orderedOrders);
            }
		    return View(orders);
        }
	}
}
