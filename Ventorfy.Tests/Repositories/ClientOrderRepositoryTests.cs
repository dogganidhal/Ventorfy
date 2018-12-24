using System;
using System.Collections.Generic;
using Ventorfy.DataAccess.Model.Orders;
using Ventorfy.DataAccess.Repository;
using Ventorfy.DataAccess.Repository.Inventory;
using Ventorfy.DataAccess.Repository.Orders;
using Ventorfy.DataAccess.Repository.Products;
using Ventorfy.DataAccess.Repository.Users;
using Xunit;

namespace Ventorfy.Tests.Repositories
{
	public class ClientOrderRepositoryTests
	{

		private readonly IUserRepository _UserRepository = RepositoryFactory.Instance.UserRepository;
		private readonly IStoreRepository _StoreRepository = RepositoryFactory.Instance.StoreRepository;
		private readonly IProductRepository _ProductRepository = RepositoryFactory.Instance.ProductRepository;
		private readonly IClientOrderRepository _ClientOrderRepository = RepositoryFactory.Instance.ClientOrderRepository;

		[Fact]
		public async void CreateOrderItems_InsertsIntoDatabase()
		{

			var admin = await this._UserRepository.CreateUser(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
				Guid.NewGuid().ToString());
			var store = await this._StoreRepository.CreateStore(admin, Guid.NewGuid().ToString());
			var productCategory = await this._ProductRepository.CreateProductCategory(Guid.NewGuid().ToString());
			var firstProduct =
				await this._ProductRepository.CreateProduct(store, Guid.NewGuid().ToString(), productCategory, 10.99);
			var secondProduct =
				await this._ProductRepository.CreateProduct(store, Guid.NewGuid().ToString(), productCategory, 10.99);
			var thirdProduct =
				await this._ProductRepository.CreateProduct(store, Guid.NewGuid().ToString(), productCategory, 10.99);
			
			var orderItems = new List<OrderItem>(
				new [] {new OrderItem(firstProduct, 10), new OrderItem(secondProduct, 20), new OrderItem(thirdProduct, 5)}
			);

			var insertedItems = await this._ClientOrderRepository.CreateOrderItems(orderItems);

			foreach (var insertedItem in insertedItems)
				Assert.NotNull(insertedItem.Id);

		}
		
		[Fact]
		public async void SubmitClientOrder_InsertsIntoDatabase()
		{

			var author = await this._UserRepository.CreateUser(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
				Guid.NewGuid().ToString());
			var store = await this._StoreRepository.CreateStore(author, Guid.NewGuid().ToString());
			var productCategory = await this._ProductRepository.CreateProductCategory(Guid.NewGuid().ToString());
			var firstProduct =
				await this._ProductRepository.CreateProduct(store, Guid.NewGuid().ToString(), productCategory, 10.99);
			var secondProduct =
				await this._ProductRepository.CreateProduct(store, Guid.NewGuid().ToString(), productCategory, 10.99);
			var thirdProduct =
				await this._ProductRepository.CreateProduct(store, Guid.NewGuid().ToString(), productCategory, 10.99);
			
			var items = new List<OrderItem>(
				new [] {new OrderItem(firstProduct, 10), new OrderItem(secondProduct, 20), new OrderItem(thirdProduct, 5)}
			);

			var orderItems = await this._ClientOrderRepository.CreateOrderItems(items);

			var clientOrder = await this._ClientOrderRepository.SubmitClientOrder(author.Id, orderItems);
			
			Assert.NotNull(clientOrder?.Id);
			Assert.Equal(clientOrder.Author.Id, author.Id);
			Assert.Equal(clientOrder.Author.Store.Id, store.Id);


		}
		
	}
}