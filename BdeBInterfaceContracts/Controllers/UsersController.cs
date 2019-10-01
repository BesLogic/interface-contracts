using BdeBInterfaceContracts.Models;
using BdeBInterfaceContracts.Repositories;
using System.Web.Mvc;
using BdeBInterfaceContracts.Services;

namespace BdeBInterfaceContracts.Controllers
{
	public class UsersController : Controller
	{
		public ActionResult Index(OrderBy orderBy = OrderBy.None)
		{
			var userRepository = new UserRepository();

            #region EX 3.0 (Sprint 2)

            // EX 3.0
            // Dans ce sprint, notre client nous a demandé de compléter la
            // fonctionnalité de tri en l'ajoutant aux Orders et aux Users.
            // Nous avons vu comment faire pour l'ajouter aux Orders, c'est
            // maintenant à vous de jouer pour les Users!
            // Appliquez tout ce que nous avons vu jusqu'à présent pour
            // implémenter la dernière fonctionnalité de ce sprint!

            #endregion

            return View(userRepository);
		}
	}
}
