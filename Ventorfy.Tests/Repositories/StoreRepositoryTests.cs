using System;
using System.Collections.Generic;
using System.Linq;
using GraphQL.Client;
using Ventorfy.Common.Utils;
using Ventorfy.DataAccess.GraphQL;
using Ventorfy.DataAccess.GraphQL.Mutations;
using Ventorfy.DataAccess.GraphQL.Queries;
using Ventorfy.DataAccess.Model.Inventory;
using Ventorfy.DataAccess.Model.Users;
using Ventorfy.DataAccess.Repository;
using Ventorfy.DataAccess.Repository.Inventory;
using Xunit;

namespace Ventorfy.Tests.Repositories
{
	public class StoreRepositoryTests
	{

		private readonly IStoreRepository _Repository = RepositoryFactory.Instance.CreateStoreRepository();
		private readonly GraphQLClient _Client = new GraphQLClient("https://ventorfy.herokuapp.com/v1alpha1/graphql");
		private readonly User _Admin;

		public StoreRepositoryTests()
		{
			var userName = Guid.NewGuid().ToString();
			var fullName = Guid.NewGuid().ToString();
			var passwordHash = SecurePasswordHasher.Hash(Guid.NewGuid().ToString());

			var request = new InsertUserRequest(userName: userName, fullName: fullName, passwordHash: passwordHash);
			var response = this._Client.PostAsync(request).Result;
			this._Admin = response.GetDataFieldAs<InsertResult<User>>("insert_User").Result.First();

			
		}

		[Fact]
		public async void CreateStore_InsertsIntoDatabaseAndReturnsId()
		{

			var store = this._Repository.CreateStore(admin: this._Admin, name: Guid.NewGuid().ToString()).Result;

			var getStoreByIdRequest = new GetStoreByIdRequest(store.Id);
			var getStoreByIdResponse = await this._Client.PostAsync(getStoreByIdRequest);

			var stores = getStoreByIdResponse.GetDataFieldAs<ICollection<Store>>("Store");
			
			Assert.NotEmpty(stores);
			Assert.Equal(store.Id, stores.First().Id);
			Assert.Equal(store.Name, stores.First().Name);
			Assert.Equal(store.Admin.Id, stores.First().Admin.Id);
			Assert.Equal(store.Admin.UserName, stores.First().Admin.UserName);

		}

		[Fact]
		public async void AddStaffMember_CreatesMember()
		{

			var userName = Guid.NewGuid().ToString();
			var store = await this._Repository.CreateStore(this._Admin, Guid.NewGuid().ToString());
			await this._Repository.AddStaffMember(userName: userName, fullName: Guid.NewGuid().ToString(),
				password: Guid.NewGuid().ToString(), store: store);

			var getUserByUserNameRequest = new GetUserByUserNameRequest(userName);
			var response = await this._Client.PostAsync(getUserByUserNameRequest);
			var users = response.GetDataFieldAs<ICollection<User>>("User");
			
			Assert.NotEmpty(users);

			var user = users.First();
			
			Assert.Equal(user.UserName, userName);
			Assert.NotNull(user.Store);
			Assert.Equal(user.Store.Id, store.Id);
			Assert.Equal(user.Store.Name, store.Name);

		}

		[Fact]
		public async void AddStaffMember_ReturnsStoreWithNewStaffMember()
		{
			
			var userName = Guid.NewGuid().ToString();
			var store = await this._Repository.CreateStore(this._Admin, Guid.NewGuid().ToString());
			var newStaffMember = await this._Repository.AddStaffMember(userName: userName, fullName: Guid.NewGuid().ToString(),
				password: Guid.NewGuid().ToString(), store: store);
			
			var getStoreByIdRequest = new GetStoreByIdRequest(store.Id);
			var response = await this._Client.PostAsync(getStoreByIdRequest);

			var stores = response.GetDataFieldAs<ICollection<Store>>("Store");
			
			Assert.NotEmpty(stores);

			var returnedStore = stores.First();
			
			Assert.Equal(returnedStore.Id, store.Id);
			Assert.Equal(returnedStore.Name, store.Name);
			
			Assert.Contains(returnedStore.StaffMembers, user => user.Id == newStaffMember.Id);

		}
		
	}
}