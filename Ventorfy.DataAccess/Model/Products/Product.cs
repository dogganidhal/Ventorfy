
using System;
using Ventorfy.DataAccess.Model.Inventory;

namespace Ventorfy.DataAccess.Model.Products
{
	public class Product
	{

		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Reference { get; set; }
		public ProductCategory Category { get; set; }
		public double Price { get; set; }
		public Provider Provider { get; set; }
		public ProductLot ProductLot { get; set; }
		public DateTime Created { get; set; }

	}
}