using BdeBInterfaceContracts.Models;
using BdeBInterfaceContracts.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BdeBInterfaceContracts.Services
{
	public class MegaService
	{
		private static readonly OrderRepository _orders =
			new OrderRepository();

		private static readonly UserRepository _users =
			new UserRepository();

		private static readonly UserRoleRepository _userRoles =
			new UserRoleRepository();

		private readonly Regex _emailRegex =
			new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

		public string GetName(User user) =>
			$"{user.FirstName} {user.LastName}";

		public bool ValidateEmail(User user) =>
			_emailRegex.IsMatch($"{user.FirstName}.{user.LastName}@example.com");

		public void SendEmail(User user)
		{
			var to = $"{user.FirstName}.{user.LastName}@example.com";
			var title = "Courriel";
			var email = new
			{
				to,
				title,
			};

			// Pretend we send an email, here.
		}

		public IEnumerable<Order> GetUserOrders(User user) =>
			_orders
				.Where(order => order.User.Id == user.Id);

		public IEnumerable<string> GetCurrentEmails() =>
			_users
				.Select(user => $"{user.FirstName}.{user.LastName}@example.com");

		public IEnumerable<UserRole> GetUnusedRoles()
		{
			var currentRoleIds = _users
				.Select(user => user.Role)
				.Select(role => role.Id)
				.ToArray();

			return _userRoles
				.Where(role => !currentRoleIds.Contains(role.Id));
		}
	}
}
