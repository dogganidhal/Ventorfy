using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Client;
using Ventorfy.Common.Exceptions;
using Ventorfy.Common.Utils;
using Ventorfy.DataAccess.GraphQL;
using Ventorfy.DataAccess.GraphQL.Mutations;
using Ventorfy.DataAccess.GraphQL.Queries;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.Repository.Users
{
	public class UserRepository : GraphQLRepository, IUserRepository
	{

		public UserRepository(GraphQLClient client): base(client)
		{
			
		}
		
		public async Task<User> CreateUser(string userName, string password, string fullName)
		{

			var request = GraphQLMutationManager.GetMutationRequest(GraphQLMutationManager.MutationRequest.InsertUser, new
			{
				UserName = userName, 
				FullName = fullName, 
				PasswordHash = SecurePasswordHasher.Hash(password)
			});
			var response = await this._Client.PostAsync(request);

			if (response.Errors?.Length > 0)
			{
				throw new DuplicateUserException(userName);
			}
			
			var insertResult = response.GetDataFieldAs<InsertResult<User>>("insert_User");

			return insertResult.Result.First();

		}

		public async Task<User> Login(string userName, string password)
		{

			var request = GraphQLQueryManager.GetQueryRequest(
				GraphQLQueryManager.QueryRequest.GetUserByUserName, new
				{
					UserName = userName
				});
			var response = await this._Client.PostAsync(request);
			var users = response.GetDataFieldAs<ICollection<User>>("User");
			
			if (!users.Any())
				throw new AccountNotFoundException(userName);

			var user = users.First();

			if (!SecurePasswordHasher.Verify(password, user.PasswordHash))
				throw new WrongPasswordException();

			return user;
			
		}
		
	}
}