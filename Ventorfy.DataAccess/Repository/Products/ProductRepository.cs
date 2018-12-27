using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Client;
using Ventorfy.Common.Exceptions;
using Ventorfy.DataAccess.GraphQL;
using Ventorfy.DataAccess.GraphQL.Mutations;
using Ventorfy.DataAccess.GraphQL.Queries;
using Ventorfy.DataAccess.Model.Inventory;
using Ventorfy.DataAccess.Model.Products;

namespace Ventorfy.DataAccess.Repository.Products
{
	public class ProductRepository : GraphQLRepository, IProductRepository
	{
		public ProductRepository(GraphQLClient client) : base(client)
		{
		}

		public async Task<ProductCategory> CreateProductCategory(string name)
		{
			var request = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.InsertProductCategory, new
				{
					Name = name
				});
			var response = await this._Client.PostAsync(request);
			var insertResponse = response.GetDataFieldAs<InsertResult<ProductCategory>>("insert_ProductCategory");

			return insertResponse.Result.First();
		}

		public async Task<Product> CreateProduct(Store store, string reference, ProductCategory category, double price,
			Provider provider = null,
			string name = null)
		{
			var insertProductRequest = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.InsertProduct, new
				{
					Reference = reference, 
					CategoryId = category.Id, 
					Price = price,
					Name = name, 
					ProviderId = provider?.Id
				});
			var insertProductResponse = await this._Client.PostAsync(insertProductRequest);
			var insertProductResult = insertProductResponse.GetDataFieldAs<InsertResult<Product>>("insert_Product");
			var product = insertProductResult.Result.First();

			var insertProductLotRequest = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.InsertProductLot, new
				{
					StoreId = store.Id, 
					ProductId = product.Id
				});
			var insertProductLotResponse = await this._Client.PostAsync(insertProductLotRequest);
			var insertProductLotResult =
				insertProductLotResponse.GetDataFieldAs<InsertResult<ProductLot>>("insert_ProductLot");

			var productLot = insertProductLotResult.Result.First();

			var updateProductLotRequest = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.UpdateProduct_SetProductLot, new
				{
					Id = product.Id, 
					ProductLotId = productLot.Id
				});
			var updateProductLotResponse = await this._Client.PostAsync(updateProductLotRequest);
			var updateResult = updateProductLotResponse.GetDataFieldAs<InsertResult<Product>>("update_Product");

			return updateResult.Result.First();
		}

		public async Task<Product> GetProductById(Guid id)
		{
			var request = GraphQLQueryManager.GetQueryRequest(
				GraphQLQueryManager.QueryRequest.GetProductById,
				new
				{
					Id = id
				}
			);
			var response = await this._Client.PostAsync(request);
			var products = response.GetDataFieldAs<ICollection<Product>>("Product");

			if (products.Count == 0)
				throw new ProductNotFoundException(id);

			return products.First();
		}

		public async Task<ProductLot> AlterQuantity(ProductLot productLot, AlterQuantityDelegate @delegate)
		{
			var alterProductLotQuantityRequest = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.AlterProductLotQuantity, new
				{
					ProductLotId = productLot.Id,  
					NewQuantity = @delegate(productLot.Quantity)
				});
			var alterProductLotQuantityResponse = await this._Client.PostAsync(alterProductLotQuantityRequest);
			var alterProductLotQuantityResult =
				alterProductLotQuantityResponse.GetDataFieldAs<InsertResult<ProductLot>>("update_ProductLot");

			return alterProductLotQuantityResult.Result.First();
		}

		public async Task<Product> SetProvider(Product product, Guid providerId)
		{
			var request = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.UpdateProduct_SetProvider, new
				{
					ProductId = product.Id,  
					ProviderId = providerId
				});
			var response = await this._Client.PostAsync(request);
			var products = response.GetDataFieldAs<ICollection<Product>>("Product");

			return products.First();
		}

		public async Task<ICollection<Product>> GetProductsByStoreId(Guid storeId)
		{

			var request = GraphQLQueryManager.GetQueryRequest(GraphQLQueryManager.QueryRequest.GetProductsByStoreId, new
			{
				StoreId = storeId
			});
			var response = await this._Client.PostAsync(request);
			return response.GetDataFieldAs<ICollection<Product>>("Product");

		}
	}
}