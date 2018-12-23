using GraphQL.Common.Request;
using Ventorfy.DataAccess.Model.Users;

namespace Ventorfy.DataAccess.GraphQL.Mutations
{
	public class InsertUserRequest : GraphQLRequest
	{

		public InsertUserRequest(string userName, string fullName, string passwordHash) : base()
		{
			this.Query = @"
				mutation InsertUser($userName: String, $fullName: String, $passwordHash: String) {
					insert_User(
						objects: [
							{UserName: $userName, FullName: $fullName, PasswordHash: $passwordHash}
						]
					)
					{
						returning {
							Id
							UserName
							FullName
							PasswordHash
						}
					}
				}
			";
			this.Variables = new
			{
				UserName = userName,
				FullName = fullName,
				PasswordHash = passwordHash
			};
		}
		
	}
}