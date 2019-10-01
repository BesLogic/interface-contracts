using System;

namespace BdeBInterfaceContracts.Models
{
    public interface IHasCreateDate
    {
        #region EX 1.1

        // Cette interface est vide... Pas surprenant que notre code ne
        // fonctionne pas! Il faudrait ajouter une propriété à notre interface,
        // de type DateTime (c'est le type qui contient les dates et les temps,
        // en C#), et avec le même nom qu'on a voulu utiliser dans le
        // SortingService, soit Creation.
        // On peut aller voir l'interface INameable, si on a besoin
        // d'inspiration!
        // Comme la propriété n'a seulement besoin que d'être lue, dans notre
        // service, on peut la mettre en Get only (pas de setter).

        // Une fois fait, allons à EX 1.2 pour vérifier que C# reconnait bien
        // notre changement!

        #endregion
    }
}
