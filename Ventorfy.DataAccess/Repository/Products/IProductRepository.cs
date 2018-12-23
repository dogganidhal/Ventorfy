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
		Task<Product> CreateProduct(string reference, ProductCategory category, double price, Provider provider = null, string name = null);
		Task<Product> GetProductById(Guid id);
		Task<ProductLot> AlterQuantity(Product product, AlterQuantityDelegate @delegate);
		Task<Product> SetProvider(Product product, string providerName);

	}
}