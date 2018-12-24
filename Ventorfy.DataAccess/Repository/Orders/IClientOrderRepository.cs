using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventorfy.DataAccess.Model.Orders;

namespace Ventorfy.DataAccess.Repository.Orders
{

	public delegate bool ClientOrderFilter(ClientOrder order);
	
	public interface IClientOrderRepository : IOrderRepository<ClientOrder>
	{
		
		Task<ICollection<ClientOrder>> SelectOrders(Guid storeId, ClientOrderFilter filter);

	}
}