﻿using System;
using GraphQL.Client;
using Ventorfy.DataAccess.Repository.Inventory;
using Ventorfy.DataAccess.Repository.Users;

namespace Ventorfy.DataAccess.Repository
{
	public class RepositoryFactory
	{
		
		public static RepositoryFactory Instance { get; } = new RepositoryFactory();

		private readonly GraphQLClientOptions _GraphQlClientOptions = new GraphQLClientOptions();

		private RepositoryFactory()
		{
			this._GraphQlClientOptions.EndPoint = new Uri("https://ventorfy.herokuapp.com/v1alpha1/graphql");
		}

		public IUserRepository CreateUserRepository()
		{
			return new UserRepository(_GraphQlClientOptions);
		}

		public IStoreRepository CreateStoreRepository()
		{
			return new StoreRepository(_GraphQlClientOptions);
		}
		
	}
}