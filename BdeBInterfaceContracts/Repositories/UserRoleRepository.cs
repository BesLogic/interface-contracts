using BdeBInterfaceContracts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdeBInterfaceContracts.Repositories
{
	public class UserRoleRepository : IEnumerable<UserRole>
	{
		private static readonly List<UserRole> _orders = new List<UserRole>
		{
			new UserRole
			{
				Id = 0,
				Name = "User",
			},
			new UserRole
			{
				Id = 1,
				Name = "Admin",
			},
		};

		public IEnumerator<UserRole> GetEnumerator() => _orders.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => _orders.GetEnumerator();
	}
}
