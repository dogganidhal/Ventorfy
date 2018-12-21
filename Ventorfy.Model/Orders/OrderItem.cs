using Ventorfy.Model.Products;

namespace Ventorfy.Model.Orders
{
	public class OrderItem
	{
		
		public int Id { get; set; }
		public Product Product { get; set; }
		public int Count { get; set; }

	}
}