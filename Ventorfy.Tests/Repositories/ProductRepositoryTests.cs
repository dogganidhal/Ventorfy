using System;
using System.Collections.Generic;
using System.Linq;
using GraphQL.Client;
using Ventorfy.Common.Utils;
using Ventorfy.DataAccess.GraphQL;
using Ventorfy.DataAccess.GraphQL.Mutations;
using Ventorfy.DataAccess.GraphQL.Queries;
using Ventorfy.DataAccess.Model.Inventory;
using Ventorfy.DataAccess.Model.Products;
using Ventorfy.DataAccess.Model.Users;
using Ventorfy.DataAccess.Repository;
using Ventorfy.DataAccess.Repository.Products;
using Xunit;

namespace Ventorfy.Tests.Repositories
{
	public class ProductRepositoryTests
	{

		private readonly IProductRepository _Repository;
		private readonly GraphQLClient _Client = GraphQLUtils.CreateGraphQlClient();

		public ProductRepositoryTests()
		{
			this._Repository = RepositoryFactory.Instance.ProductRepository;
		}

		[Fact]
		public async void CreateProductCategory_InsertsIntoDatabase()
		{

			var productCategory = await this._Repository.CreateProductCategory("TestProduct");
			
			Assert.NotNull(productCategory);
			Assert.NotNull(productCategory.Id);

			var getCategoryByIdRequest = GraphQLQueryManager.GetQueryRequest(
				GraphQLQueryManager.QueryRequest.GetProductCategoryById, new
				{
					Id = productCategory.Id
				});
			var getCategoryByIdResponse = await this._Client.PostAsync(getCategoryByIdRequest);
			var getCategoryByIdResult =
				getCategoryByIdResponse.GetDataFieldAs<ICollection<ProductCategory>>("ProductCategory");
			
			Assert.NotEmpty(getCategoryByIdResult);
			
			Assert.Equal(productCategory.Id, getCategoryByIdResult.First().Id);
			Assert.Equal(productCategory.Name, getCategoryByIdResult.First().Name);
			Assert.Equal(productCategory.Products.Count, getCategoryByIdResult.First().Products.Count);

		}
		
		[Fact]
		public async void CreateProduct_InsertsIntoDatabase()
		{
			var createAdminRequest = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.InsertUser, 
				new
				{
					UserName = Guid.NewGuid().ToString(),
					FullName = Guid.NewGuid().ToString(),
					PasswordHash = SecurePasswordHasher.Hash(Guid.NewGuid().ToString())
				});
			var createAdminResponse = await this._Client.PostAsync(createAdminRequest);
			var admin = createAdminResponse.GetDataFieldAs<InsertResult<User>>("insert_User").Result.First();

			var createStoreRequest = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.InsertStore, new
				{
					AdminId = admin.Id, 
					Name = Guid.NewGuid().ToString()
				});
			var createStoreResponse = await this._Client.PostAsync(createStoreRequest);
			var store = createStoreResponse.GetDataFieldAs<InsertResult<Store>>("insert_Store").Result.First();

			var productCategory = await this._Repository.CreateProductCategory("TestProduct");
			var product = await this._Repository.CreateProduct(store, Guid.NewGuid().ToString(), productCategory, 10.00);
			
			Assert.NotNull(product?.Id);
			
			var getProductByIdRequest = GraphQLQueryManager.GetQueryRequest(
				GraphQLQueryManager.QueryRequest.GetProductById, new
				{
					Id = product.Id
				});
			var getProductByIdResponse = await this._Client.PostAsync(getProductByIdRequest);
			var getProductByIdResult = getProductByIdResponse.GetDataFieldAs<ICollection<Product>>("Product");
			
			Assert.NotEmpty(getProductByIdResult);
	
			Assert.Equal(getProductByIdResult.First().Id, product.Id);
			Assert.Equal(getProductByIdResult.First().Reference, product.Reference);
			Assert.Equal(getProductByIdResult.First().Price, product.Price);
			Assert.Equal(getProductByIdResult.First().Provider, product.Provider);
			Assert.Equal(getProductByIdResult.First().Category.Id, product.Category.Id);

		}
		
		[Fact]
		public async void CreateProduct_CreatesEmptyProductLot()
		{
			var createAdminRequest = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.InsertUser, 
				new
				{
					UserName = Guid.NewGuid().ToString(),
					FullName = Guid.NewGuid().ToString(),
					PasswordHash = SecurePasswordHasher.Hash(Guid.NewGuid().ToString())
				});
			var createAdminResponse = await this._Client.PostAsync(createAdminRequest);
			var admin = createAdminResponse.GetDataFieldAs<InsertResult<User>>("insert_User").Result.First();

			var createStoreRequest = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.InsertStore, new
				{
					AdminId = admin.Id, 
					Name = Guid.NewGuid().ToString()
				});
			var createStoreResponse = await this._Client.PostAsync(createStoreRequest);
			var store = createStoreResponse.GetDataFieldAs<InsertResult<Store>>("insert_Store").Result.First();

			var productCategory = await this._Repository.CreateProductCategory("TestProduct");
			var product = await this._Repository.CreateProduct(store, Guid.NewGuid().ToString(), productCategory, 10.00);
			
			Assert.NotNull(product?.Id);
			Assert.NotNull(product?.ProductLot);

			var getProductLotRequest = GraphQLQueryManager.GetQueryRequest(GraphQLQueryManager.QueryRequest.GetProductLotByProductId,
				new
				{
					ProductId = product.Id
				});

			var getProductLotResponse = await this._Client.PostAsync(getProductLotRequest);
			var getProductLotResult = getProductLotResponse.GetDataFieldAs<ICollection<ProductLot>>("ProductLot");
			
			Assert.Equal(getProductLotResult.Count, 1);

			var productLot = getProductLotResult.First();
			
			Assert.NotNull(productLot);
			Assert.Equal(productLot.Id, product.ProductLot.Id);
			Assert.Equal(productLot.Quantity, 0);

		}
		
	}
}