using System;

namespace BdeBInterfaceContracts.Models
{
    #region EX 1.4

    // EX 1.4
    // Ici, le changement est des plus simples!
    // Il faut uniquement ajouter l'interface IHasCreateDate à la liste des
    // interfaces de notre classe Product, pour que C# comprenne qu'elle
    // implémente cette interface.
    // Comme le nom et le type de la propriété dans l'interface et celle dans
    // la classe sont les mêmes (DateTime Creation), aucun autre changement
    // n'est requis!

    // Une fois le changement fait, on peut continuer à EX 1.5.

    #endregion

    public class Product : INameable
    {
		public int Id { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
        public DateTime Creation { get; set; }

        public string Name => Description;
	}
}
