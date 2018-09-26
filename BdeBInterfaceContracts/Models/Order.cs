using System;

namespace BdeBInterfaceContracts.Models
{
	public class Order
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public User User { get; set; }
		public decimal Price { get; set; }
	}
}
