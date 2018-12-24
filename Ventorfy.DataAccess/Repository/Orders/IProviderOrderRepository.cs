using System.Collections.Generic;
using System.Threading.Tasks;
using Ventorfy.DataAccess.Model.Orders;

namespace Ventorfy.DataAccess.Repository.Orders
{
	
	public delegate bool ProviderOrderFilter(ProviderOrder order);
	
	public interface IProviderOrderRepository : IOrderRepository<ProviderOrder>
	{
		
		Task<ICollection<ClientOrder>> SelectOrders(ProviderOrderFilter filter);
		
	}
}