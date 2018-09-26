using BdeBInterfaceContracts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdeBInterfaceContracts.Repositories
{
	public class UserRepository : IEnumerable<User>
	{
		private static readonly UserRoleRepository _userRoles =
			new UserRoleRepository();

		private static readonly List<User> _users = new List<User>
		{
			new User
			{
				Id = 0,
				FirstName = "Yannick",
				LastName = "Bessette",
				Email = "yannick.bessette@beslogic.com",
				Role = GetRole(1),
				Creation = DateTime.Now.AddDays(-2),
				// Modification = DateTime.Now,
			},
			new User
			{
				Id = 1,
				FirstName = "Pascal",
				LastName = "Laprade",
				Email = "pascal.laprade@beslogic.com",
				Role = GetRole(1),
				Creation = DateTime.Now.AddDays(-8),
				// Modification = DateTime.Now.AddMinutes(-30),
			},
		};

		public IEnumerator<User> GetEnumerator() => _users.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => _users.GetEnumerator();

		private static UserRole GetRole(int id) =>
			_userRoles.FirstOrDefault(role => role.Id == id);
	}
}