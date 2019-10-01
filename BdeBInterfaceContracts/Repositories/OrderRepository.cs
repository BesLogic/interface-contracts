using BdeBInterfaceContracts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BdeBInterfaceContracts.Repositories
{
	public class OrderRepository : IEnumerable<Order>
    {
        private const decimal RebateForMembers = 0.9m;

        private static readonly UserRepository _userRepository =
            new UserRepository();

        private static readonly ProductRepository _productRepository =
            new ProductRepository();

        private static readonly List<Order> _orders = new List<Order>
		{
			new Order
			{
				Id = 0,
                Product = GetProduct(0),
                PricePaid = GetProduct(0).Price * RebateForMembers,
				User = GetUser(2),
				Creation = DateTime.Now.AddDays(-2),
			},
			new Order
			{
				Id = 1,
                Product = GetProduct(1),
                PricePaid = GetProduct(1).Price,
				User = GetUser(1),
				Creation = DateTime.Now.AddDays(-2).AddHours(4),
			},
			new Order
			{
				Id = 2,
                Product = GetProduct(2),
                PricePaid = GetProduct(2).Price * RebateForMembers,
				User = GetUser(2),
				Creation = DateTime.Now.AddDays(-7),
			},
		};

        public void CreateOrder(Order order) =>
            _orders.Add(order);

		public IEnumerator<Order> GetEnumerator() => _orders.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => _orders.GetEnumerator();

		private static User GetUser(int id) =>
			_userRepository.FirstOrDefault(user => user.Id == id);

        private static Product GetProduct(int id) =>
            _productRepository.FirstOrDefault(product => product.Id == id);
    }
}
