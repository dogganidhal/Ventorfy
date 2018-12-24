using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ventorfy.DataAccess.Model.Products
{
	public class ProductCategory
	{

		public Guid Id { get; set; } 
		public string Name { get; set; }
		public ICollection<Product> Products { get; set; }

	}
}