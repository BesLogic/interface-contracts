using System.Collections.Generic;
using System.Linq;
using BdeBInterfaceContracts.Models;

namespace BdeBInterfaceContracts.Services
{
	public class SortingService
	{
	    public IEnumerable<TValue> OrderByName<TValue>(
	        IEnumerable<TValue> values)
            where TValue : INameable =>
            values.OrderBy(value => value.Name);

        #region EX 1.0 (Sprint 1)

        // EX 1.0
        // Copiez la méthode "OrderByName" au-dessus, et faites les changements
        // suivants :
        // - Nommez la nouvelle méthode "OrderByCreationDateDescending"
        // - Changez l'interface de "INameable" à "IHasCreateDate"
        // - Changez "OrderBy" par "OrderByDescending"
        // - Changez "value.Name" par "value.Creation"

        // Voyez-vous l'erreur que nous donne C#? Pourquoi avons-nous cette
        // erreur? Qu'est-ce qui nous manque? Allons voir à EX 1.1 pour
        // comprendre ce qui manque à notre interface IHasCreateDate...

        // ---------------------------------------------------------------------
        // EX 1.2 (Au retour) Maintenant que les changements sont faits, C#
        // ne nous donne plus d'erreur! Allons à l'exercice EX 1.3.

        #endregion
    }
}
