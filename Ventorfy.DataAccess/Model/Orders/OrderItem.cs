using System;
using Ventorfy.DataAccess.Model.Products;

namespace Ventorfy.DataAccess.Model.Orders
{
	public class OrderItem
	{
		
		public Guid Id { get; set; }
		public Product Product { get; set; }
		public int Count { get; set; }

		public OrderItem()
		{
			
		}

		public OrderItem(Product product, int count)
		{
			this.Product = product;
			this.Count = count;
		}
	}
}