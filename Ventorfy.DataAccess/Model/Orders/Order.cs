using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.Model.Orders
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