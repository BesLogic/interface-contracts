using BdeBInterfaceContracts.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BdeBInterfaceContracts.Repositories
{
	public class ProductRepository : IEnumerable<Product>
	{
		private static readonly List<Product> _orders = new List<Product>
		{
			new Product
            {
				Id = 0,
				Description = "Café",
				Price = 2m,
				Creation = DateTime.Now.AddDays(-10),
			},
			new Product
            {
				Id = 1,
				Description = "Sandwich",
				Price = 7.5m,
				Creation = DateTime.Now.AddDays(-9),
			},
			new Product
            {
				Id = 2,
				Description = "Popcorn",
				Price = 1.15m,
				Creation = DateTime.Now.AddDays(-8),
			},
		};

		public IEnumerator<Product> GetEnumerator() => _orders.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => _orders.GetEnumerator();
	}
}
