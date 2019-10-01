using System;

namespace BdeBInterfaceContracts.Models
{
    #region EX 2.1

    // EX 2.1
    // Comme avec la classe Product, il faut simplement ajouter les deux
    // interfaces, INameable et IHasCreateDate.
    // Par contre, IHasCreateDate semble bien correct, mais INameable nous
    // donne une erreur... On dirait qu'il faut implémenter une propriété
    // "Name"? Allons à EX 2.2 pour corriger le problème!

    #endregion

    public class Order
	{
		public int Id { get; set; }
		public Product Product { get; set; }
        public decimal PricePaid { get; set; }
		public User User { get; set; }
        public DateTime Creation { get; set; }

        #region EX 2.2

        // Avec la class Product, les développeurs avaient déjà ajouté la
        // propriété Name, mais ici, elle n'existe pas encore!
        // Or, INameable nous oblige justement à respecter le contrat établi
        // par INameable, soit d'avoir une propriété de type "string"
        // appellée "Name". Mais... on n'a pas de nom, ici!
        // L'équipe de UI a utilisé Product.Description dans la table, il semble
        // donc logique que nous utilisions cette même propriété pour le tri.
        // Sortez vos connaissances de C# pour implémenter cette propriété
        // de manière à ce qu'elle retourne la même valeur que la Description
        // du Product associé à cet Order.
        // Au besoin, allez voir la class Product pour trouver l'inspiration
        // nécessaire, ou demandez de l'aide!
        // Une fois fait, allez à EX 2.3 pour continuer!

        #endregion
    }
}
