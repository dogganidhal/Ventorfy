using System.Linq;
using System.Threading.Tasks;
using GraphQL.Client;
using Ventorfy.Common.Utils;
using Ventorfy.DataAccess.GraphQL;
using Ventorfy.DataAccess.GraphQL.Mutations;
using Ventorfy.DataAccess.GraphQL.Mutations.Store;
using Ventorfy.DataAccess.GraphQL.Mutations.User;
using Ventorfy.DataAccess.Model.Inventory;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.Repository.Inventory
{
	public class StoreRepository : IStoreRepository
	{

		private readonly GraphQLClient _Client;

		public StoreRepository(GraphQLClientOptions options)
		{
			this._Client = new GraphQLClient(options);
		}
		
		public async Task<Store> CreateStore(User admin, string name)
		{

			var request = new InsertStoreRequest(adminId: admin.Id, name: name);
			var response = await this._Client.PostAsync(request);
			var insertResult = response.GetDataFieldAs<InsertResult<Store>>("insert_Store");

			return insertResult.Result.First();

		}

		public async Task<User> AddStaffMember(Store store, string userName, string fullName, string password)
		{
			
			var request = new InsertUserRequest(userName: userName, fullName: fullName, passwordHash: SecurePasswordHasher.Hash(password), storeId: store.Id);
			var response = await this._Client.PostAsync(request);
			var insertResult = response.GetDataFieldAs<InsertResult<User>>("insert_User");

			return insertResult.Result.First();

		}
		
	}
}