using BdeBInterfaceContracts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdeBInterfaceContracts.Repositories
{
	public class OrderRepository : IEnumerable<Order>
	{
		private static readonly UserRepository _userRepository =
			new UserRepository();

		private static readonly List<Order> _orders = new List<Order>
		{
			new Order
			{
				Id = 0,
				Description = "Café",
				Price = 2m,
				User = GetUser(1),
				Creation = DateTime.Now.AddDays(-2),
				// Modification = DateTime.Now.AddMinutes(-45),
			},
			new Order
			{
				Id = 1,
				Description = "Sandwich",
				Price = 7.5m,
				User = GetUser(1),
				Creation = DateTime.Now.AddDays(-2),
				// Modification = DateTime.Now.AddMinutes(-30),
			},
			new Order
			{
				Id = 2,
				Description = "Chaise de bureau",
				Price = 74.99m,
				User = GetUser(0),
				Creation = DateTime.Now.AddDays(-7),
				// Modification = DateTime.Now.AddHours(-8),
			},
		};

		public IEnumerator<Order> GetEnumerator() => _orders.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => _orders.GetEnumerator();

		private static User GetUser(int id) =>
			_userRepository.FirstOrDefault(user => user.Id == id);
	}
}
