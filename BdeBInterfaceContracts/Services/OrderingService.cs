using System.Collections.Generic;
using System.Linq;
using BdeBInterfaceContracts.Models;

namespace BdeBInterfaceContracts.Services
{
	public class OrderingService
	{
	    public IEnumerable<T> OrderByCreationDate<T>(
	        IEnumerable<T> orders)
            where T : IHasCreationDate =>
	        orders.OrderBy(order => order.Creation);
	}
}
