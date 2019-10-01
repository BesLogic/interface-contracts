using System;

namespace BdeBInterfaceContracts.Models
{
	public class Order : IHasCreationDate
	{
		public int Id { get; set; }
		public Product Product { get; set; }
        public decimal PricePaid { get; set; }
		public User User { get; set; }
        public DateTime Creation { get; set; }
	}
}
