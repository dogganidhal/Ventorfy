using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ventorfy.DataAccess.Model.Products;

namespace Ventorfy.DataAccess.Model.Orders
{
	public class OrderItem
	{
		
		public int Id { get; set; }
		public Product Product { get; set; }
		public int Count { get; set; }

	}
}