using BdeBInterfaceContracts.Extensions;
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

            #region EX 4.4

            // EX 4.4
            // Commençons par appeler notre méthode d'extension sur le user.
            // Ça s'écrit "var priceCalculator = user.GetPriceCalculator();".
            // Puis, à l'aide du priceCalculator, allez ajuster le PriceToPay
            // plus bas pour qu'il soit calculé selon la logique du client,
            // plutôt que codé au prix du produit.
            // À ce point des exercices, nous vous laissons déterminer comment
            // vous y prendre : vous avez un IProductCalculator et un Product,
            // vous devriez donc tout avoir pour réussir!
            // Allez à EX 4.5 par la suite.

            var viewModel = new StoreViewModel
            {
                Product = product,
                User = user,
                // EX 4.4
                // Utilisez le bon prix, ici!
                PriceToPay = product.Price,
                NewUserId = userId,
            };

            #endregion

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

            #region EX 4.5

            // EX 4.5
            // Il faut reproduire la même logique qu'à EX 4.4, ici, mais cette
            // fois, il faut assigner le prix à la propriété "PricePaid",
            // puisque c'est ici que la transaction est complétée.
            // Une fois terminé, vous avez fini avec le Sprint 3!
            // Testez votre fonctionnalité pour vous assurer d'être prêt
            // pour votre démo chez le client!

            var order = new Order
            {
                Id = _pseudoRandomGenerator.Next(),
                Product = product,
                User = user,
                PricePaid = product.Price,
                Creation = DateTime.Now,
            };

            #endregion

            orderRepository.CreateOrder(order);

            return RedirectToAction("Index", "Orders");
        }
    }
}
