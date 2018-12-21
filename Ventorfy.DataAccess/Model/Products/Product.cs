
using Ventorfy.Model.Inventory;

namespace Ventorfy.Model.Products
{
	public class Product
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public string Reference { get; set; }
		public ProductCategory Category { get; set; }
		public double Price { get; set; }
		public Provider Provider { get; set; }

	}
}