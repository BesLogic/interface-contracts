using BdeBInterfaceContracts.Models;
using System.Collections;
using System.Collections.Generic;

namespace BdeBInterfaceContracts.Repositories
{
	public class UserRoleRepository : IEnumerable<UserRole>
	{
		private static readonly List<UserRole> _orders = new List<UserRole>
		{
			new UserRole
			{
				Id = 0,
				Name = "Admin",
			},
			new UserRole
			{
				Id = 1,
				Name = "Caissier",
			},
            new UserRole
            {
                Id = 2,
                Name = "Membre Avantages",
            },
        };

		public IEnumerator<UserRole> GetEnumerator() => _orders.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => _orders.GetEnumerator();
	}
}
