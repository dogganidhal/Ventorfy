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
		
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		
		[Required]
		public DateTime Date { get; set; }
		
		[Required]
		public IEnumerable<OrderItem> Items { get; set; }
		
		[Required]
		public User Author { get; set; }

		public double ComputePrice()
		{
			return this.Items.Sum(orderItem => orderItem.Product.Price * orderItem.Count);
		}

	}
}