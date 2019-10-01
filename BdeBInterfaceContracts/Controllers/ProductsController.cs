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

            if (orderBy == OrderBy.Name)
            {
                var sortingService = new SortingService();
                var orderedProducts = sortingService.OrderByName(productRepository);
                return View(orderedProducts);
            }
            #region EX 1.3

            // EX 1.3
            // Il est temps d'appeler notre nouvelle méthode!
            // Ajoutons un else if qui sera contre OrderBy.CreationDateDesc.
            // On peut copier le code d'en haut et faire les changements requis.
            // À part la condition du if, il faut simplement changer le nom de
            // la méthode pour celle que l'on vient de créer.
            // Hmmm, encore une erreur de C#, un peu plus obscure, cette
            // fois-ci. C# nous dit qu'il est impossible de traiter un Product
            // comme un IHasCreateDate...
            // En effet, en C#, il faut toujours indiquer explicitement qu'une
            // classe implémente une interface! Même si la classe a déjà les
            // propriétés requises, C# attend de nous qu'on lui confirme
            // qu'un contrat existe bien!
            // Allons à EX 1.4!

            // -----------------------------------------------------------------
            // EX 1.5 (au retour)
            // Et voilà, tout marche, maintenant!
            // Il est temps de tester l'application!

            #endregion

            return View(productRepository);
        }
    }
}
