using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ventorfy.DataAccess.Model.Inventory;

namespace Ventorfy.DataAccess.Model.Products
{
	public class ProductLot
	{

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		
		[Required]
		public Product Product { get; set; }
		
		[Required]
		public int Quantity { get; set; }
		
		[Required]
		public Store Store { get; set; }

	}
}