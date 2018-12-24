using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ventorfy.DataAccess.Model.Orders;

namespace Ventorfy.DataAccess.Repository.Orders
{
	
	public interface IOrderRepository<TOrder>
	{
		
		Task<ICollection<OrderItem>> CreateOrderItems(ICollection<OrderItem> items);
		Task<TOrder> SubmitClientOrder(Guid authorId, ICollection<OrderItem> items);
		
	}
}