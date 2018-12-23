using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Client;
using GraphQL.Common.Exceptions;
using Ventorfy.Common.Exceptions;
using Ventorfy.Common.Utils;
using Ventorfy.DataAccess.GraphQL;
using Ventorfy.DataAccess.GraphQL.Mutations;
using Ventorfy.DataAccess.GraphQL.Mutations.User;
using Ventorfy.DataAccess.GraphQL.Queries;
using Ventorfy.DataAccess.GraphQL.Queries.User;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.Repository.Users
{
	public class UserRepository : IUserRepository
	{

		private readonly GraphQLClient _Client;

		public UserRepository(GraphQLClientOptions options)
		{
			this._Client = new GraphQLClient(options);
		}
		
		public async Task<User> CreateUser(string userName, string password, string fullName)
		{
			
			var request = new InsertUserRequest(userName: userName, fullName: fullName, passwordHash: SecurePasswordHasher.Hash(password));
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
			
			var request = new GetUserByUserNameRequest(userName);
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