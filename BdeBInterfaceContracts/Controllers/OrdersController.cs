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
			var orderRepository = new OrderRepository();

            #region EX 2.0 (Sprint 2)

            // EX 2.0
            // Notre client nous demande cette fois-ci d'implémenter les mêmes
            // tris que pour les produits. Facile!
            // Hmmm... Il va falloir faire quelques changements, mais on peut
            // commencer par ajouter le même code que celui qu'on trouve dans
            // le ProductsController. Idéalement, on va aussi changer les noms
            // de variables pour mieux représenter le domaine avec lequel on
            // travaille dans ce contrôleur.
            // Mais il y a quelque chose qui cloche : C# nous donne à nouveau
            // la même erreur obscure que plus tôt, en nous disant qu'il est
            // impossible de convertir un Order en INameable ou IHasCreateDate.
            // Il va falloir encore une fois aller ajouter les interfaces
            // à la classe Order, pour que C# comprenne qu'elles implémentent
            // le contrat qui est défini par ces deux interfaces!
            // Allons à EX 2.1.

            // -----------------------------------------------------------------
            // EX 2.3 (au retour)
            // C# est content, maintenant!
            // C'est le temps de tester que tout fonctionne en lançant
            // l'application!

            #endregion

            return View(orderRepository);
        }
	}
}
