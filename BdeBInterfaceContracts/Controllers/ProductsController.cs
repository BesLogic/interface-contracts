using BdeBInterfaceContracts.Models;
using BdeBInterfaceContracts.Repositories;
using BdeBInterfaceContracts.Services;
using System.Web.Mvc;

namespace BdeBInterfaceContracts.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index(OrderBy orderBy = OrderBy.None)
        {
            var productRepository = new ProductRepository();

            //if (orderBy == OrderBy.CreationDate)
            //{
            //    var orderingService = new SortingService();
            //    var orderedProducts = orderingService.OrderByCreationDate(productRepository);
            //    return View(orderedProducts);
            //}
            return View(productRepository);
        }
    }
}
