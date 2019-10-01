using BdeBInterfaceContracts.Models;
using BdeBInterfaceContracts.Repositories;
using System;
using System.Linq;
using System.Web.Mvc;

namespace BdeBInterfaceContracts.Controllers
{
    public class StoreController : Controller
    {
        private readonly Random _pseudoRandomGenerator = new Random();

        // GET: Store
        public ActionResult Index(int productId, int? userId)
        {
            var productRepository = new ProductRepository();
            var userRepository = new UserRepository();

            var product = productRepository
                .FirstOrDefault(potentialProduct => potentialProduct.Id == productId);

            var user = userRepository
                .FirstOrDefault(potentialUser => potentialUser.Id == userId);

            var viewModel = new StoreViewModel
            {
                Product = product,
                User = user,
                // Using the new PriceCalculators, add the logic so that the
                // price is set to the correct value when a user is 
                PriceToPay = product.Price,
                NewUserId = userId,
            };

            return View(viewModel);
        }

        // POST: Store/Confirm
        public ActionResult Confirm(int productId, int? userId)
        {
            var productRepository = new ProductRepository();
            var userRepository = new UserRepository();
            var orderRepository = new OrderRepository();

            var product = productRepository
                .FirstOrDefault(potentialProduct => potentialProduct.Id == productId);

            var user = userRepository
                .FirstOrDefault(potentialUser => potentialUser.Id == userId);

            var order = new Order
            {
                Id = _pseudoRandomGenerator.Next(),
                Product = product,
                User = user,
                PricePaid = product.Price,
                Creation = DateTime.Now,
            };

            orderRepository.CreateOrder(order);

            return RedirectToAction("Index", "Orders");
        }
    }
}
