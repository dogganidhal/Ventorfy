using System;
using GraphQL.Client;
using Ventorfy.DataAccess.GraphQL;
using Ventorfy.DataAccess.Repository.Inventory;
using Ventorfy.DataAccess.Repository.Products;
using Ventorfy.DataAccess.Repository.Users;

namespace Ventorfy.DataAccess.Repository
{
	public class RepositoryFactory
	{
		
		public static RepositoryFactory Instance { get; } = new RepositoryFactory();

		public IUserRepository UserRepository
		{
			// TODO: Check network health, then decide which Implementor of IUserRepository to instantiate
			get => new UserRepository(GraphQLUtils.CreateGraphQlClient());
		}
		
		public IStoreRepository StoreRepository
		{
			// TODO: Check network health, then decide which Implementor of IStoreRepository to instantiate
			get => new StoreRepository(GraphQLUtils.CreateGraphQlClient());
		}
		
		public IProductRepository ProductRepository
		{
			// TODO: Check network health, then decide which Implementor of IProductRepository to instantiate
			get => new ProductRepository(GraphQLUtils.CreateGraphQlClient());
		}

		private RepositoryFactory()
		{
			
		}
		
	}
}