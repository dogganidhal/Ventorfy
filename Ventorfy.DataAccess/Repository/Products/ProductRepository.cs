using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GraphQL.Client;
using Ventorfy.DataAccess.GraphQL;
using Ventorfy.DataAccess.GraphQL.Mutations.Product;
using Ventorfy.DataAccess.GraphQL.Queries.Product;
using Ventorfy.DataAccess.Model.Inventory;
using Ventorfy.DataAccess.Model.Products;

namespace Ventorfy.DataAccess.Repository.Products
{
	public class ProductRepository : IProductRepository
	{

		private readonly GraphQLClient _Client;

		public ProductRepository(GraphQLClientOptions options)
		{
			this._Client = new GraphQLClient(options);
		}
		
		public async Task<ProductCategory> CreateProductCategory(string name)
		{
			
			var request = new InsertProductCategoryRequest(name);
			var response = await this._Client.PostAsync(request);
			var insertResponse = response.GetDataFieldAs<InsertResult<ProductCategory>>("insert_ProductCategory");

			return insertResponse.Result.First();
			
		}

		public async Task<Product> CreateProduct(string reference, ProductCategory category, double price, Provider provider = null,
			string name = null)
		{

			var request = new InsertProductRequest(reference: reference, categoryId: category.Id, price: price, name: name, providerId: provider?.Id);
			var response = await this._Client.PostAsync(request);
			var insertResponse = response.GetDataFieldAs<InsertResult<Product>>("insert_Product");

			return insertResponse.Result.First();

		}

		public async Task<Product> GetProductById(Guid id)
		{

			var request = new GetProductByIdRequest(id);
			var response = await this._Client.PostAsync(request);
			var products = response.GetDataFieldAs<ICollection<Product>>("Product");
			
			if (products.Count == 0)
				throw new Exception(); // TODO: Implement product not found exception

			return products.First();

		}

		public Task<ProductLot> AlterQuantity(Product product, AlterQuantityDelegate @delegate)
		{
			throw new NotImplementedException();
		}

		public Task<Product> SetProvider(Product product, string providerName)
		{
			throw new NotImplementedException();
		}
		
	}
}