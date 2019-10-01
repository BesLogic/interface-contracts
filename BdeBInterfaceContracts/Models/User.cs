using System;

namespace BdeBInterfaceContracts.Models
{
	public class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public UserRole Role { get; set; }
        public DateTime Creation { get; set; }

        // EX 3.1
        // Petite surprise, ici! Product et Order avaient une description
        // qui nous donnait le nom.
        // Ici, le client voudrait en fait que l'on fasse le tri par nom de
        // famille des utilisateurs, pour permettre aux caissiers de plus
        // facilement rechercher un client lorsqu'il ou elle se présente à
        // la caisse.
        // À vous d'implémenter le contrat de INameable!
	}
}
