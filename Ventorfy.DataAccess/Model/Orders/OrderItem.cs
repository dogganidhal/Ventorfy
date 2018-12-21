using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ventorfy.DataAccess.Model.Products;

namespace Ventorfy.DataAccess.Model.Orders
{
	public class OrderItem
	{
		
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		
		[Required]
		public Product Product { get; set; }
		
		[Required]
		public int Count { get; set; }

	}
}