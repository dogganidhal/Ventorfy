using System;
using System.Collections.Generic;
using Ventorfy.DataAccess.Model.Products;

namespace Ventorfy.DataAccess.Model.Inventory
{
	public class Provider
	{
		
		public Guid Id { get; set; }
		public string Name { set; get; }
		public ICollection<Product> Products { get; set; }
		
	}
}