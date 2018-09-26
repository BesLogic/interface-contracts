using System;

namespace BdeBInterfaceContracts.Models
{
	public class Order : IHasCreationDate
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public User User { get; set; }
		public decimal Price { get; set; }
        public DateTime Creation { get; set; }
	}
}
