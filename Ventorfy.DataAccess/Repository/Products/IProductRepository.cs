using System;
using System.Threading.Tasks;
using Ventorfy.DataAccess.Model.Inventory;
using Ventorfy.DataAccess.Model.Products;

namespace Ventorfy.DataAccess.Repository.Products
{

	public delegate int AlterQuantityDelegate(int old);
	
	public interface IProductRepository
	{
		
		Task<ProductCategory> CreateProductCategory(string name);
		Task<Product> CreateProduct(Store store, string reference, ProductCategory category, double price,
			Provider provider = null, string name = null);
		Task<Product> GetProductById(Guid id);
		Task<ProductLot> AlterQuantity(ProductLot productLot, AlterQuantityDelegate @delegate);
		Task<Product> SetProvider(Product product, Guid providerName);

	}
}