using System;
using System.Collections.Generic;
using System.Linq;
using Ventorfy.Model.Users;

namespace Ventorfy.Model.Orders
{
	public abstract class Order
	{

		public int Id { get; set; }
		public DateTime Date { get; set; }
		public IEnumerable<OrderItem> Items { get; set; }
		public User Author { get; set; }

		public double ComputePrice()
		{
			return this.Items.Sum(orderItem => orderItem.Product.Price * orderItem.Count);
		}

	}
}