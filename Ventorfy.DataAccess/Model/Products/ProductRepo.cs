using Ventorfy.Model.Inventory;

namespace Ventorfy.Model.Products
{
	public class ProductRepo
	{

		public int Id { get; set; }
		public Product Product { get; set; }
		public int Quantity { get; set; }
		public Store Store { get; set; }

	}
}