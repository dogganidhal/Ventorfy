using System.Linq;
using System.Threading.Tasks;
using GraphQL.Client;
using Ventorfy.Common.Utils;
using Ventorfy.DataAccess.GraphQL;
using Ventorfy.DataAccess.GraphQL.Mutations;
using Ventorfy.DataAccess.Model.Inventory;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.Repository.Inventory
{
	public class StoreRepository : GraphQLRepository, IStoreRepository
	{
		
		public StoreRepository(GraphQLClient client) : base(client)
		{
			
		}
		
		public async Task<Store> CreateStore(User admin, string name)
		{

			var request = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.InsertStore, new
				{
					AdminId = admin.Id,  
					Name = name
				});
			var response = await this._Client.PostAsync(request);
			var insertResult = response.GetDataFieldAs<InsertResult<Store>>("insert_Store");
			var store = insertResult.Result.First();

			var updateUserRequest = GraphQLMutationManager.GetMutationRequest(
				GraphQLMutationManager.MutationRequest.UpdateUser_SetStore, new
				{
					Id = admin.Id,
					StoreId = store.Id
				});
			
			// No need to await the result
			await this._Client.PostAsync(updateUserRequest); 

			return store;

		}

		public async Task<User> AddStaffMember(Store store, string userName, string fullName, string password)
		{

			var request = GraphQLMutationManager.GetMutationRequest(GraphQLMutationManager.MutationRequest.InsertUser, new
			{
				UserName = userName,
				FullName = fullName,
				PasswordHash = SecurePasswordHasher.Hash(password), 
				StoreId = store.Id
			});
			var response = await this._Client.PostAsync(request);
			var insertResult = response.GetDataFieldAs<InsertResult<User>>("insert_User");

			return insertResult.Result.First();

		}

	}
}