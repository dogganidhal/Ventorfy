using System;
using GraphQL.Common.Request;

namespace Ventorfy.DataAccess.GraphQL.Mutations.User
{
	public class InsertUserRequest : GraphQLRequest
	{

		public InsertUserRequest(string userName, string fullName, string passwordHash, Guid? storeId = null) : base()
		{
			this.Query = @"
				mutation InsertUser($userName: String, $fullName: String, $passwordHash: String, $storeId: ID = null) {
					insert_User(
						objects: [
							{UserName: $userName, FullName: $fullName, PasswordHash: $passwordHash, StoreId: $storeId}
						]
					)
					{
						returning {
							Id
							UserName
							FullName
							PasswordHash
							Store {
								Id
								Name
							}
						}
					}
				}
			";
			this.Variables = new
			{
				UserName = userName,
				FullName = fullName,
				PasswordHash = passwordHash,
				StoreId = storeId
			};
		}
		
	}
}