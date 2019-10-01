using BdeBInterfaceContracts.Models;
using BdeBInterfaceContracts.Repositories;
using System.Web.Mvc;
using BdeBInterfaceContracts.Services;

namespace BdeBInterfaceContracts.Controllers
{
	public class OrdersController : Controller
	{
		public ActionResult Index(OrderBy orderBy = OrderBy.None)
		{
			var orders = new OrderRepository();
		    if (orderBy == OrderBy.CreationDate)
		    {
		        var sortingService = new SortingService();
		        var orderedOrders = sortingService.OrderByCreationDate(orders);
		        return View(orderedOrders);
            }
		    return View(orders);
        }
	}
}
