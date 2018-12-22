
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ventorfy.DataAccess.Model.Inventory;

namespace Ventorfy.DataAccess.Model.Products
{
	public class Product
	{

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		
		[Required, StringLength(64)]
		public string Name { get; set; }
		
		[Required, StringLength(64)]
		public string Reference { get; set; }
		
		[Required]
		public ProductCategory Category { get; set; }
		
		[Required]
		public double Price { get; set; }
		
		public Provider Provider { get; set; }

	}
}