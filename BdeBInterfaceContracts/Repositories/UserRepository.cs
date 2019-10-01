using BdeBInterfaceContracts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
				Role = GetRole(0),
				Creation = DateTime.Now.AddDays(-12),
			},
			new User
			{
				Id = 1,
				FirstName = "Pascal",
				LastName = "Laprade",
				Role = GetRole(1),
				Creation = DateTime.Now.AddDays(-8),
			},
            new User
            {
                Id = 2,
                FirstName = "Stéphane",
                LastName = "Lévesque",
                Role = GetRole(2),
                Creation = DateTime.Now.AddDays(-4),
			},
        };

		public IEnumerator<User> GetEnumerator() => _users.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => _users.GetEnumerator();

		private static UserRole GetRole(int id) =>
			_userRoles.FirstOrDefault(role => role.Id == id);
	}
}