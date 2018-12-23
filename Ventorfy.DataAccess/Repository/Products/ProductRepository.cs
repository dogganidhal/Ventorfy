using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GraphQL.Client;
using Ventorfy.Common.Exceptions;
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

		public async Task<Product> CreateProduct(Store store, string reference, ProductCategory category, double price,
			Provider provider = null,
			string name = null)
		{

			var insertProductRequest = new InsertProductRequest(reference: reference, categoryId: category.Id, price: price, name: name, providerId: provider?.Id);
			var insertProductResponse = await this._Client.PostAsync(insertProductRequest);
			var insertProductResult = insertProductResponse.GetDataFieldAs<InsertResult<Product>>("insert_Product");
			var product = insertProductResult.Result.First();
			
			var insertProductLotRequest = new InsertProductLotRequest(storeId: store.Id, productId: product.Id);
			var insertProductLotResponse = await this._Client.PostAsync(insertProductLotRequest);
			var insertProductLotResult =
				insertProductLotResponse.GetDataFieldAs<InsertResult<ProductLot>>("insert_ProductLot");

			var productLot = insertProductLotResult.Result.First();
			
			var updateProductLotRequest = new UpdateProductSetProductLotRequest(product.Id, productLot.Id);
			var updateProductLotResponse = await this._Client.PostAsync(updateProductLotRequest);
			var updateResult = updateProductLotResponse.GetDataFieldAs<InsertResult<Product>>("update_Product");

			return updateResult.Result.First();

		}

		public async Task<Product> GetProductById(Guid id)
		{

			var request = new GetProductByIdRequest(id);
			var response = await this._Client.PostAsync(request);
			var products = response.GetDataFieldAs<ICollection<Product>>("Product");

			if (products.Count == 0)
				throw new ProductNotFoundException(id);

			return products.First();

		}

		public async Task<ProductLot> AlterQuantity(ProductLot productLot, AlterQuantityDelegate @delegate)
		{
			
			var alterProductLotQuantityRequest = new AlterProductQuantityRequest(productLot.Id, @delegate(productLot.Quantity));
			var alterProductLotQuantityResponse = await this._Client.PostAsync(alterProductLotQuantityRequest);
			var alterProductLotQuantityResult =
				alterProductLotQuantityResponse.GetDataFieldAs<InsertResult<ProductLot>>("update_ProductLot");
			
			return alterProductLotQuantityResult.Result.First();

		}

		public async Task<Product> SetProvider(Product product, Guid providerId)
		{
			
			var request = new UpdateProductSetProviderRequest(product.Id, providerId);
			var response = await this._Client.PostAsync(request);
			var products = response.GetDataFieldAs<ICollection<Product>>("Product");

			return products.First();

		}
		
	}
}